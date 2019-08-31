using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreenCursor : MonoBehaviour {

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update ()
    {
       
    }
}
