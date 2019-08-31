using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public Player playerHealth;

    public float restartDelay = 20f;

    float restartTimer;

	// Use this for initialization
	void Start ()
    {
        //playerHealth.health.CurrentVal = 100;
    }
	
	// Update is called once per frame
	void Update () {
        if (playerHealth.health.CurrentVal <= 0)
        {
            restartTimer += Time.deltaTime;
            //SceneManager.LoadScene(2);
            Cursor.visible = true;
        }
	}
}
