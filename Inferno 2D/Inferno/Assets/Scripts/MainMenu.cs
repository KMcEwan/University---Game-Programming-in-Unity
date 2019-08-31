using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	// Use this for initialization
	public void Play ()
    {
        SceneManager.LoadScene(1);
	}
	
	// Update is called once per frame
	public void Quit ()
    {
       // UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
	}

    public void Continue()
    {
        SceneManager.LoadScene(0);
    }
}
