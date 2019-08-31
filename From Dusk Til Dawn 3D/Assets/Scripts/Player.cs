using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public SMGController smgController;
    public PistolController pistolController;
    public ShotgunController shotgunController;
    public AidController Aidcontroller;

    public int RandomSMGBulletAmount;
    public int RandomPistolBulletAmount;
    public int RandomShotgunBulletAmount;

    public int MaxPistol;
    public int CollectedPistol;

    public int MaxSMG;
    public int CollectedSMG;

    public int MaxShotgun;
    public int CollectedShotgun;

    public int MaxAid;
    public int CollectedAid;

    public bool PlayerDead = false;
    private float StaminaSpeed = 0.08f;

    public float delay;

    //public float turnSpeed = 50f;

    [SerializeField]
    public Stat health;

    [SerializeField]
    private Stat Stamina;
    public static int Health { get; internal set; }

    public AudioSource[] AudioClips = null;

    
    private void Awake()
    {
        health.Initialize();
        Stamina.Initialize();
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        MaxPistol = pistolController.MaximumPistolBulletCarry;
        CollectedPistol = pistolController.PistolbulletsCollected;

        MaxSMG = smgController.MaxSMGBulletCarry;
        CollectedSMG = smgController.SMGbulletsCollected;

        MaxShotgun = shotgunController.MaxShotgunBulletCarry;
        CollectedShotgun = shotgunController.ShotgunbulletsCollected;

        MaxAid = Aidcontroller.MaxAid;
        CollectedAid = Aidcontroller.AidCollected;

        StaminaSystem();
        HealthSounds();


        if (health.CurrentVal <= 0 && !PlayerDead)
        {
            PlayerDead = true;
            StartCoroutine(LoadLevelAfterDelay(delay));
            AudioClips[5].Stop();            
        }

        
        ScoreCheck();
    }


    void HealthSounds()
    {
        if (health.CurrentVal <=10)
        {
            if (!AudioClips[2].isPlaying)
            {
                AudioClips[2].Play();
            }
        }
    }

    void HealthSystem()
    {
        if (health.CurrentVal >= 100)
        {
            health.CurrentVal = 100;
        }

        if (health.CurrentVal <= 0)
        {
            health.CurrentVal = 0;
            
        }
    }

    void StaminaSystem()
    {

        {
            if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && (Input.GetKey(KeyCode.LeftShift)))
            {
                CharacterController.speed = 5;
                if (!AudioClips[1].isPlaying)
                {
                    AudioClips[1].Play();
                }
            }

            if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && !(Input.GetKey(KeyCode.LeftShift)))
            {                
                CharacterController.speed = 2;
                if (!AudioClips[0].isPlaying)
                {
                    AudioClips[0].Play();
                };
            }
            if ((Stamina.CurrentVal == 0) && (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0))
            {
                CharacterController.speed = 2;               
            }
            if ((Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0))
            {
               
            }

        }



        if ((Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) && (Input.GetKey(KeyCode.LeftShift)))    //Decrease or increase of stamina depending on movement
        {
            Stamina.CurrentVal -= 0.5f * StaminaSpeed;
        }
        else
        {
            Stamina.CurrentVal += 1 * StaminaSpeed;
        }

        if (Stamina.CurrentVal >= 500)
        {
            Stamina.CurrentVal = 500;
        }
        if (Stamina.CurrentVal <= 0)
        {
            Stamina.CurrentVal = 0;
        }

    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }

    void OnCollisionEnter(Collision col)
        {

        if (col.gameObject.tag == "SMGAmmo")
        {
            if (CollectedSMG < MaxSMG)
            {
                AudioClips[3].Play();
                RandomSMGBulletAmount = Random.Range(1, 30);
                Destroy(col.gameObject);
                smgController.SMGbulletsCollected += RandomSMGBulletAmount;
            }
        }

        if (col.gameObject.tag == "PistolAmmo")
        {
            if (CollectedPistol < MaxPistol)
            {
                AudioClips[3].Play();
                RandomPistolBulletAmount = Random.Range(1, 30);
                Destroy(col.gameObject);
                pistolController.PistolbulletsCollected += RandomPistolBulletAmount;
            }
        }

        if (col.gameObject.tag == "ShotgunAmmo")
        {
            if (CollectedShotgun < MaxShotgun)
            {
                AudioClips[3].Play();
                RandomShotgunBulletAmount = Random.Range(1, 30);
                Destroy(col.gameObject);
                shotgunController.ShotgunbulletsCollected += RandomShotgunBulletAmount;
            }
        }

        if (col.gameObject.tag == "FirstAid")
        {
            if (CollectedAid < MaxAid)
            {
                AudioClips[4].Play();
                Destroy(col.gameObject);
                Aidcontroller.AidCollected += 1;
            }
        }
        /*
        if (col.gameObject.tag == "VampHands")
        {
            Debug.Log("Hit by vamp hands");
            health.CurrentVal -= 10;
        }*/
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "VampHands")
        {
            Debug.Log("Hit by vamp hands");
            health.CurrentVal -= 5;
            AudioClips[5].Play();
        }
    }

    void ScoreCheck()
    {
        if (ScoreScript.scoreValue >=100)
        {
            ScoreScript.scoreValue = 0;
            health.CurrentVal = 100;
            Stamina.CurrentVal = 100;
        }
    }
}

