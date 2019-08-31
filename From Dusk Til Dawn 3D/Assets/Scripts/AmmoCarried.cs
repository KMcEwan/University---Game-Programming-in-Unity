using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCarried : MonoBehaviour {

    public SMGController smgController;
    public ShotgunController shotgunController;
    public PistolController pistolController;
    public WeaponController weaponController;
    public GameObject ammoView;



    // Update is called once per frame
    void Update()
    {
        ammoView.GetComponent<Text>().text = "" + smgController.SMGbulletsCollected;
    }
}