using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletScript : MonoBehaviour
{

    public GameObject SparkEffect;
    public float Speed = 10f;
    Vector3 PrevPos;

    // Use this for initialization
    void Start()
    {
        PrevPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionStay(Collision collision)
    {
        var instantiatedEffect = Instantiate(SparkEffect, transform.position, SparkEffect.transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(instantiatedEffect.gameObject, 0.5f);
    }
    
}