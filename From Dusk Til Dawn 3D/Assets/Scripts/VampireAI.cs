using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class VampireAI : MonoBehaviour
{

    Transform Player;    
    NavMeshAgent nav;
    Animator Vampireanim;
    private int Vamphealth;

    public int Timer;
    //float speed = 30f;
    public float AnimationChangeRange;

    public AudioSource[] AudioClips = null;
    

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
        Vampireanim = GetComponent<Animator>();
        InvokeRepeating("RandomAudio", 5f, 10f);
        
    }

    private void Start()
    {
        
    }

    void Update()
    {
        float DistanceToTarget = Vector3.Distance(transform.position, Player.position);
        Timer++;
        

        
        if (DistanceToTarget < 1.5f)
        {
            Debug.Log("DistanceToTarget < 1.5f");
            GetComponent<NavMeshAgent>().enabled = false;
            Vampireanim.SetBool("IsRunning", false);
            Vampireanim.SetBool("IsAttacking", true);
            Vampireanim.SetBool("IsAttacking2", true);
        }

        if (DistanceToTarget > AnimationChangeRange)
        {
            //if (Vamphealth > 0)
           
                Debug.Log("DistanceToTarget > AnimationChangeRange");
                GetComponent<NavMeshAgent>().enabled = true;
                nav.SetDestination(Player.position);
                Vampireanim.SetBool("IsRunning", true);
                Vampireanim.SetBool("IsAttacking", false);
                Vampireanim.SetBool("IsAttacking2", false);
                Vampireanim.SetBool("IsShouting", false);
           
            //else
            //{
               // GetComponent<NavMeshAgent>().enabled = false;
            //}            

        }
        

        if (DistanceToTarget < AnimationChangeRange)
        {
            Debug.Log("DistanceToTarget < AnimationChangeRange");
            GetComponent<NavMeshAgent>().enabled = true;
            nav.SetDestination(Player.position);
            Vampireanim.SetBool("IsRunning", false);
            Vampireanim.SetBool("IsAttacking", true);
            Vampireanim.SetBool("IsAttacking2", true);                    
        }   
    }

  
    void RandomAudio()
    {
        int SoundChoice = Random.Range(0, AudioClips.Length);
        AudioClips[SoundChoice].Play();
        Debug.Log("Sound Choice" + SoundChoice);
    }

    public void VampireDead()
    {
        GetComponent<NavMeshAgent>().enabled = false;
    }
}
