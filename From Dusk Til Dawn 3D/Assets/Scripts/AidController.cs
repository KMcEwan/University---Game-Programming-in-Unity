using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidController : MonoBehaviour {


    public int MaxAid;

    public int AidCollected;

    Animator Aidanim;
    public AudioSource[] AudioClips = null;

    private void Awake()
    {
        MaxAid = 12;
    }

    void Start ()
    {
        Aidanim = GameObject.FindWithTag("AidArms").GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ((Input.GetMouseButtonDown(0)) && AidCollected > 0)
        {
            Aidanim.SetBool("IsApplying", true);
            AudioClips[0].Play();
            GameObject.FindWithTag("Player").GetComponent<Player>().health.CurrentVal += 15;
            AidCollected--;
            Debug.Log("Aid script");
        }
    }
}
