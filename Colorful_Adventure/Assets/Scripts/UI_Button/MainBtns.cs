using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainBtns : MonoBehaviour {

    public BTNType currentType;
    public GameManagerLogic manager;
    public static bool GameIsPaused = false;

    public GameObject Parent_stop;


    private void Start() {
    }
    public void OnBtnClick() {
        Time.timeScale = 1;
        switch(currentType)
        {

            case BTNType.GameStart:
                Debug.Log("and then choose the level");
                GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("LevelScene1");
                break;
            

            case BTNType.HowtoPlay:
                Debug.Log("Enjoy the tutorials");
                GetComponent<AudioSource>().Play();
                SceneManager.LoadScene("Tutorial_1");
                break;

            case BTNType.Quit:
                GetComponent<AudioSource>().Play();
                GameQuit();
                break;
            
            case BTNType.Reset:
                SceneManager.LoadScene(manager.stage);
                GetComponent<AudioSource>().Play();
                break;
            
            case BTNType.Stop:
                Parent_stop.transform.Find("StopPopup").gameObject.SetActive(true);
                Time.timeScale = 0;
                GetComponent<AudioSource>().Play();
                break;
            
            case BTNType.Return:
                Parent_stop.transform.Find("StopPopup").gameObject.SetActive(false);
                GetComponent<AudioSource>().Play();
                Time.timeScale = 1;
                break;
            
            case BTNType.Continue:
                SceneManager.LoadScene((manager.stage) +1);
                GetComponent<AudioSource>().Play();
                Time.timeScale = 1;
                break;
            
            case BTNType.BacktoMainMenu:
                SceneManager.LoadScene("MainMenu");
                GetComponent<AudioSource>().Play();
                Time.timeScale = 1;
                break;


        }
    }

    public void GameQuit() {
        Application.Quit();
    }
}
