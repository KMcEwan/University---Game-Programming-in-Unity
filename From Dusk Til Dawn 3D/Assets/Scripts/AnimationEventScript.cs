using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventScript : MonoBehaviour {

    Animator SMGanim;
    Animator Pistolanim;
    Animator Shotgunanim;
    Animator Aidanim;
    // Use this for initialization
    void Start ()
    {
        SMGanim = GetComponent<Animator>();
        Pistolanim = GetComponent<Animator>();
        Shotgunanim = GetComponent<Animator>();
        Aidanim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ResetShooting ()
    {
        SMGanim.SetBool("IsShooting", false);
    }

    void ResetReload()
    {
        Debug.Log("Reset reload active");
        SMGanim.SetBool("IsReloading", false);
    }

    void ResetPistolShooting()
    {
        Pistolanim.SetBool("IsShooting", false);
    }

    void ResetPistolReload()
    {
        Pistolanim.SetBool("IsReloading", false);
    }

    void ResetShotgunShooting()
    {
        Shotgunanim.SetBool("IsShooting", false);
    }

    void ResetShotgunReload()
    {
        Shotgunanim.SetBool("IsReloading", false);
    }

    void ResetAidApplying()
    {
        Aidanim.SetBool("IsApplying", false);
    }
}
