using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    public bool paused;
    public CamMouseLook camMouseLook;
    public SMGController smgController;
    //public VolumeControl volumeControl;
    


    // Use this for initialization
    void Start()
    {
        paused = false;
        Cursor.visible = false;
        //volumeControl.myVolume.value = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //paused = !paused;
            SwitchPause();
        }
        if (paused)
        {
            PauseGame(true);
            //pauseMenu.SetActive(true);
            //Time.timeScale = 0;
        }
        else
        {
            PauseGame(false);
            
            //pauseMenu.SetActive(false);
            //Time.timeScale = 1;
        }

    }

    void PauseGame(bool state)
    {
        if(state)
        {
            Time.timeScale = 0.0f;
            camMouseLook.enabled = false;
            smgController.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1.0f;
            camMouseLook.enabled = true;
            smgController.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Cursor locked");
        }
        pauseMenu.SetActive(state);
    }

    public void SwitchPause()
    {
        if (paused)
        {
            paused = false;
        }
        else
        {
            paused = true;
        }
    }
    public void QuitMain()
    {
        SceneManager.LoadScene(0);
    }
    public void Continue()
    {
        paused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        ScoreScript.scoreValue = 0;
    }

    /*public void SetMasterVolume(float value)
    {
        AudioManager.instance.SetVolume(value, AudioManager.AudioChannel.Master);
    }

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }*/


}
