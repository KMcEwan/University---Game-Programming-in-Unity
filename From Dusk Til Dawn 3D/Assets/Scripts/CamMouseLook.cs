﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMouseLook : MonoBehaviour
{


    Vector2 mouseLook;                                      //Keeps track of total movement
    Vector2 smoothV;
    public float sensitivity = 2.0f;
    public float smoothing = 2.0f;

    GameObject character;


    void Start()
    {
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));  // md = mouse delta

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);                    // left/right
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);                    // up/down
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -60f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}