using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartPauseAnimation : MonoBehaviour
{

    public static bool GameIsPause = false;
    //public GameObject pauseMenuUI;
    //public GameObject ResumeUI;

    // Update is called once per frame
    void Awake() {
         DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
        Debug.Log("Space key was pressed.");
            if(GameIsPause){
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Pause(){
      //  pauseMenuUI.SetActive(true);
       // ResumeUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
        AudioListener.pause = true;
    }

    public void Resume(){
        //pauseMenuUI.SetActive(false);
        //ResumeUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
        AudioListener.pause = false;
    }

    public void Reset(){
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          Time.timeScale = 1f;
          GameIsPause = false;

    }

}
