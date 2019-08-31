using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplayer : MonoBehaviour {

    public SMGController smgController;
    public ShotgunController shotgunController;
    public PistolController pistolController;
    public WeaponController weaponController;
    public GameObject ammoView;
    //public static currentWeapon;



    // Update is called once per frame
    void Update()
    {
        ammoView.GetComponent<Text>().text = "" + smgController.SMGmagazineSize;

        /*if ((Input.GetKeyDown(KeyCode.Alpha1)) || (Input.GetKeyDown(KeyCode.Keypad1)))
        {
            
            ammoView.GetComponent<Text>().text=""+smgController.SMGmagazineSize;
        }

        if ((Input.GetKeyDown(KeyCode.Alpha2)) || (Input.GetKeyDown(KeyCode.Keypad2)))
        {
            ammoView.GetComponent<Text>().text = "" + pistolController.PistolmagazineSize;
        }

        if ((Input.GetKeyDown(KeyCode.Alpha3)) || (Input.GetKeyDown(KeyCode.Keypad3)))
        {
            ammoView.GetComponent<Text>().text = "" + shotgunController.ShotgunmagazineSize;
        }*/

    }
    /*void OnGUI()
    {
        GUI.Label(Rect(Screen.width / 2, Screen.height - 20, 150, 100), "" + smgController.SMGmagazineSize);
    }*/

}