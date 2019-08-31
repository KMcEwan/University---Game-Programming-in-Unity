using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Enemy : MonoBehaviour
{
   // public int EnemyCounterScript;
    public int Health = 100;
    public GameObject HealthPickUp;
    Animator DeathAnimator;

    public int DemonHitAmount = 0;

    public float DropRate = 0.1f;
    public float DestroyTime = 0.5f;
    public bool HealthIsCreated = false;


       // Use this for initialization
    void Start()
    {
        //EnemyCounterScript = GameObject.FindWithTag("EnemyTrigger").GetComponent<EnemySpawner>().EnemyCounter;
       
    }

    // Update is called once per frame
    void Update()
    {
        
      
        if (Health <= 0)
        {
            HitAmount();
            Debug.Log("Enemy health less than 0");
            Destroy(gameObject, DestroyTime);
           

        }

        
    }
    void OnDestroy()
    {
        if (GameObject.FindWithTag("MainCamera") != null)
        {
            GameObject.FindWithTag("MainCamera").GetComponent<EnemySpawner>().EnemyCounter -= 1;
            
            Debug.Log("oN DESTROY LVL1ENEMY");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            DemonHitAmount++;
            Debug.Log("Hit");
            Destroy(other.gameObject);
            Health -= 25;
            Debug.Log("BULLET DELETION");
            ScoreScript.scoreValue += 1;
            // Debug.Log("Enemy Health = " + Health);
        }


    }

    void HitAmount()
    { 
        if (DemonHitAmount == 4)
        {
            FindObjectOfType<AudioManager>().Play("DemonDeath");
            DemonHitAmount = 0;
        }
    }
}
