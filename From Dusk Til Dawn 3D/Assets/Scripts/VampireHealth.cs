using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class VampireHealth : MonoBehaviour
{

    public int startingHealth = 100;
    public int currentHealth;
    public int Timer;  
    private int Vamphealth;     
    public int RandomNumberForVampSpeed;

    public float sinkSpeed = 3f;
    public float AnimationChangeRange;
    float speed;

    bool isSinking;

    Animator Vampireanim;
    NavMeshAgent nav;
    CapsuleCollider capsuleCollider;
    Transform Player;    

    public AudioSource[] AudioClips = null;

    VampireSpawn vampireSpawn;    
    EnemySpawner enemySpawner;
    Player player;

    private void Awake()
    {
        currentHealth = startingHealth;
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        Vampireanim = GetComponent<Animator>();
        InvokeRepeating("RandomAudio", 5f, 10f);
        nav.speed = Random.Range(1, 8);

    }

    void Start()
    {
        Vampireanim = GetComponent<Animator>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        vampireSpawn = GameObject.FindWithTag("Spawner").GetComponent<VampireSpawn>();        
        enemySpawner = GameObject.FindWithTag("MoonTriggerForSpawn").GetComponent<EnemySpawner>();
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }


    void Update()
    {
        
        float DistanceToTarget = Vector3.Distance(transform.position, Player.position);
        Timer++;

        if (isSinking)
        {
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }

        if (enemySpawner.Spawn == false)
        {
            if (currentHealth > 0)
            {
                if (GameObject.FindGameObjectsWithTag("VampireBlood") != null)
                {
                    TakeDamage(100);
                }
            }
        } 

        if (DistanceToTarget < 1.5f)
        {
            GetComponent<NavMeshAgent>().enabled = false;
            Vampireanim.SetBool("IsRunning", false);
            Vampireanim.SetBool("IsAttacking", true);
            Vampireanim.SetBool("IsAttacking2", true);
        }

        if (DistanceToTarget > AnimationChangeRange)
        {
            if (currentHealth > 0)
            {
                GetComponent<NavMeshAgent>().enabled = true;
                nav.SetDestination(Player.position);
                Vampireanim.SetBool("IsRunning", true);
                Vampireanim.SetBool("IsAttacking", false);
                Vampireanim.SetBool("IsAttacking2", false);
                Vampireanim.SetBool("IsShouting", false);
            }
            else
            {
             GetComponent<NavMeshAgent>().enabled = false;
            }            

        }


        if (DistanceToTarget < AnimationChangeRange)
        {
            GetComponent<NavMeshAgent>().enabled = true;
            nav.SetDestination(Player.position);
            Vampireanim.SetBool("IsRunning", false);
            Vampireanim.SetBool("IsAttacking", true);
            Vampireanim.SetBool("IsAttacking2", true);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {           
            VampDeath();
            if (enemySpawner.Spawn == true)
            {
                ScoreScript.scoreValue += 5;
            }
        }
    }

    void VampDeath()
    {
        
        vampireSpawn.VampCounter--;        
        capsuleCollider.isTrigger = true;        
        Vampireanim.SetBool("IsRunning", false);
        Vampireanim.SetBool("IsAttacking", false);
        Vampireanim.SetBool("IsAttacking2", false);
        Vampireanim.SetBool("IsShouting", false);
        Vampireanim.SetBool("IsHit", false);
        Vampireanim.SetBool("IsDead", true);   


        Debug.Log("Counter from health " + vampireSpawn.VampCounter);
    }

    public void StartSinking()
    {        
        GetComponent<NavMeshAgent>().enabled = false;        
        GetComponent<Rigidbody>().isKinematic = true;        
        isSinking = true;
       // Destroy(this.gameObject, 5);
    }

    void RandomAudio()
    {
        int SoundChoice = Random.Range(0, AudioClips.Length);
        AudioClips[SoundChoice].Play();
        
    }


}
