using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MedkitDisplay : MonoBehaviour {

    public AidController aidController;
    public GameObject aidView;
    

    // Update is called once per frame
    void Update()
    {
        aidView.GetComponent<Text>().text = "" + aidController.AidCollected;
    }
    
}