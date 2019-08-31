using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayDisplay : MonoBehaviour {

    public StopEnemySpawner stopEnemySpawner;
    public GameObject dayView;
	
	
	// Update is called once per frame
	void Update () {
        dayView.GetComponent<Text>().text = "" + stopEnemySpawner.Day;
    }
}
