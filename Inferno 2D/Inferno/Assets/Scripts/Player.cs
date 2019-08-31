using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject player;

    public Sprite[] sprites;
    public Sprite[] spritesU;
    public Sprite[] spriteR;
    public Sprite[] spriteL;
    public Sprite[] Death;

    public Vector2 relativePoint;
    public bool PlayerDead = false;
    public int Timer;
   

    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;

    public AudioClip InjurySound;
    public AudioSource InjuryAudioSource;

    public Camera camera;
    float lockPos = 0;
    private float speed;
    public float offset = 0.0f;

    public int PlayerLives = 10;

    public bool deathAudio = false;
    public static int spawnVarRoom1 = 0;
    public static int spawnVarRoom2 = 0;
    public static int spawnVarRoom3 = 0;
    public static int spawnVarRoom4 = 0;
    public static int spawnVarRoom5 = 0;
    public static int spawnVarRoom6 = 0;
    public static int spawnVarRoom7 = 0;
    public static int spawnVarRoom8 = 0;
    public static int spawnVarRoom9 = 0;
    public static int spawnVarRoom10 = 0;
    public static int spawnVarRoom11 = 0;
    public static int spawnVarRoom12 = 0;


    public static int Room1 = 0;




    void Start()
    {
        speed = 3;
        Debug.Log("Player health" + PlayerLives);
        Lives();
        InjuryAudioSource.clip = InjurySound;
        spriteRenderer = GetComponent<SpriteRenderer>();
       


    }

    void ScoreCheck()
    {
        if (ScoreScript.scoreValue >= 100)
        {
            PlayerLives += 1;
            ScoreScript.scoreValue = 0;
            FindObjectOfType<AudioManager>().Play("1up");
        }
    }

    public void Lives()
    {
        if (PlayerLives >= 10)
        {
            PlayerLives = 10;
        }

        if (PlayerLives <=0)
        {
            PlayerLives = 0;
            ScoreScript.scoreValue = 0;
        }
    }



    void Update()
    {
        DeathAudio();
        TimerCheck();
        ScoreCheck();
        Lives();

        if (PlayerDead == false)
        {
            Debug.Log("Player health" + PlayerLives);
            float axisX = Input.GetAxis("Horizontal");
            float axisY = Input.GetAxis("Vertical");

            // transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed);
            transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed, Space.World);
            transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
            /*        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                            difference.Normalize();
                            float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                            transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);


           */
        }
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRenderer.sprite = sprites[index];

            var worldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
            relativePoint = transform.InverseTransformPoint(worldPosition);
        

        if (relativePoint.x < 0f && Mathf.Abs(relativePoint.x) > Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Right");
            spriteRenderer.sprite = spriteR[index];
            spriteRenderer.flipX = true;
        }
        if (relativePoint.x > 0f && Mathf.Abs(relativePoint.x) > Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Left");
            spriteRenderer.sprite = spriteL[index];
            
        }
        if (relativePoint.y > 0 && Mathf.Abs(relativePoint.x) < Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Under");
            spriteRenderer.sprite = spritesU[index];
            // DemonAnimator.SetBool("DemonUp", true);
        }
        if (relativePoint.y < 0 && Mathf.Abs(relativePoint.x) < Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Above");
            spriteRenderer.sprite = sprites[index];
        }
        if (PlayerLives == 0)
        {
            
            spriteRenderer.sprite = Death[index];
            if (spriteRenderer.sprite = Death[4])
            {
                PlayerDead = true;
                framesPerSecond = 0;
            }
            
            Timer++;
        }

    }

    void DeathAudio()
    {
        if (PlayerLives == 0)
        {

            if (deathAudio == false)
            {
                Timer++;
                FindObjectOfType<AudioManager>().Play("PlayerDeathSound");
                deathAudio = true;
                ScoreScript.scoreValue = 0;
            }
        }
    }

    void TimerCheck()
    {
        if (Timer == 223)
        {
            SceneManager.LoadScene(12);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

                   
        if (other.gameObject.tag == "Door2Bottom")
        {
            Debug.Log("");
            SceneManager.LoadScene("Room1");
        }

        if (other.gameObject.tag == "EnemyTrigger")
        {
            Debug.Log("var =" + spawnVarRoom1);
            spawnVarRoom1 = 1;
            Room1 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom2")
        {
            Debug.Log("var =" + spawnVarRoom2);
            spawnVarRoom2 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom3")
        {
            Debug.Log("TriggerRoom3 =" + spawnVarRoom3);
            spawnVarRoom3 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom4")
        {
            Debug.Log("TriggerRoom4 =" + spawnVarRoom4);
            spawnVarRoom4 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom5")
        {
            Debug.Log("TriggerRoom4 =" + spawnVarRoom5);
            spawnVarRoom5 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom6")
        {
            Debug.Log("TriggerRoom6 =" + spawnVarRoom6);
            spawnVarRoom6 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom7")
        {
            Debug.Log("TriggerRoom7 =" + spawnVarRoom7);
            spawnVarRoom7 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom8")
        {
            Debug.Log("TriggerRoom8 =" + spawnVarRoom8);
            spawnVarRoom8 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom9")
        {
            Debug.Log("TriggerRoom9 =" + spawnVarRoom9);
            spawnVarRoom9= 1;
        }

        if (other.gameObject.tag == "TriggerRoom10")
        {
            Debug.Log("TriggerRoom10 =" + spawnVarRoom10);
            spawnVarRoom10 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom11")
        {
            Debug.Log("TriggerRoom11 =" + spawnVarRoom11);
            spawnVarRoom11 = 1;
        }

        if (other.gameObject.tag == "TriggerRoom12")
        {
            Debug.Log("TriggerRoom12 =" + spawnVarRoom12);
            spawnVarRoom12 = 1;
        }

        if (other.gameObject.tag == "HealthPickUp")
        {
            Debug.Log("Health picked up");
            if (PlayerLives < 10)
            {
                Destroy(other.gameObject);
                PlayerLives += 1;
                FindObjectOfType<AudioManager>().Play("1up");
                Debug.Log("hEART DELETION");
            }
            }

        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HealthReduction");
            PlayerLives -= 1;
            InjuryAudioSource.Play();
        }

        if (other.gameObject.tag == "Fire")
        {
            Debug.Log("HealthReduction");
            PlayerLives -= 1;
            InjuryAudioSource.Play();
        }

        if (other.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("HealthReduction");
            PlayerLives -= 1;
            InjuryAudioSource.Play();
        }

        if (other.gameObject.tag == "Boss")
        {
            
            PlayerLives -= 1;
            InjuryAudioSource.Play();
        }
        
        if (other.gameObject.tag == "EndBossSheild")
        {

            PlayerLives -= 1;
            InjuryAudioSource.Play();
        }

       
    }

    

}