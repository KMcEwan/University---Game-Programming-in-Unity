using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    
    private Text TempText;


    void Start ()
    {
        TempText = GameObject.Find("Paused").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                TempText.text = ("PAUSED");
                
            }
            else
            {
                Time.timeScale = 1;
                TempText.text = ("");
                
            }

        }
    }

}
