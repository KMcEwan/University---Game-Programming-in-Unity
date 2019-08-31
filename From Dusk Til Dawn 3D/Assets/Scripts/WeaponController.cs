using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject TestGun1;
    public GameObject TestGun2;
    public GameObject TestGun3;
    public GameObject Aid;

    // Use this for initialization
    void Start()
    {
        TestGun1.gameObject.SetActive(true);
        TestGun2.gameObject.SetActive(false);
        TestGun3.gameObject.SetActive(false);
        Aid.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Alpha1)) || (Input.GetKeyDown(KeyCode.Keypad1)))
        {
            //smg key
            KillAll();
            TestGun1.gameObject.SetActive(true);
        }

        if ((Input.GetKeyDown(KeyCode.Alpha2)) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            //pistol key
            KillAll();
            TestGun2.gameObject.SetActive(true);
        }

        if ((Input.GetKeyDown(KeyCode.Alpha3)) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            //shotgun key
            KillAll();
            TestGun3.gameObject.SetActive(true);
        }

        if ((Input.GetKeyDown(KeyCode.Alpha4)) || (Input.GetKeyDown(KeyCode.Keypad4)))
        {
            //health key
            KillAll();
            Aid.gameObject.SetActive(true);
        }
    }

    void KillAll()
    {
        TestGun1.gameObject.SetActive(false);
        TestGun2.gameObject.SetActive(false);
        TestGun3.gameObject.SetActive(false);
        Aid.gameObject.SetActive(false);
    }
}