using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunController : MonoBehaviour {

    public int ShotgunbulletsCollected;
    public int ShotgunmagazineSize;
    public int MaxShotgunBulletCarry = 50;
    private float Range = 10f;

    public Rigidbody projectile;

    public float FireRate = 0.8f;
    private float NextFire = 0.0f;
    public float speed = 20;
    public Camera cam;
    Animator ShotgunAnim;
    Animator Vampireanim;

    public int pelletCount;
    public float spreadAngle;
    public float pelletFireVel = 1;
    public GameObject pellet;
    public Transform ShotgunExit;
    List<Quaternion> pellets;

    public AudioSource[] AudioClips = null;

    private ParticleSystem ShotgunParticle;

    private void Awake()
    {
        pellets = new List<Quaternion>(pelletCount);
        for (int i = 0; i < pelletCount; i++)
        {
            pellets.Add(Quaternion.Euler(Vector3.zero));
        }

        //MaxShotgunBulletCarry = 50;
    }

    void Start()
    {
        var BulletSpawnPoint = GameObject.Find("ShotgunBulletSpawn").transform;
        ShotgunAnim = GameObject.FindWithTag("ShotgunArms").GetComponent<Animator>();
        ShotgunParticle = GameObject.FindWithTag("ShotgunMuzzelFlash").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        float screenX = Screen.width / 2;
        float screenY = Screen.height / 2;

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector3(screenX, screenY));

        if (((Input.GetMouseButtonDown(0)) && ShotgunmagazineSize > 0) && (ShotgunAnim.GetBool("IsReloading") == false) && (Time.time > NextFire))
        {
            NextFire = Time.time + FireRate;
            ShotgunmagazineSize--;
            BulletSpawn();
            AudioClips[0].Play();
            if (Physics.Raycast(ray, out hit, Range))
            {
                Debug.DrawLine(transform.position, hit.point);
                transform.LookAt(hit.point);
                Debug.Log("RayCastOut");

                if (hit.collider.gameObject.tag == "VampBody")
                {
                    VampireHealth enemyhealth = hit.collider.gameObject.transform.root.GetComponentInChildren<VampireHealth>();

                    Vampireanim = hit.collider.gameObject.transform.root.GetComponentInChildren<Animator>();
                    Debug.Log("HitWithBody");
                    if (enemyhealth != null)
                    {
                        Debug.Log("enem");
                        enemyhealth.TakeDamage(50);

                    }
                    Vampireanim.SetBool("IsRunning", false);
                    Vampireanim.SetBool("IsAttacking", false);
                    Vampireanim.SetBool("IsAttacking2", false);
                    Vampireanim.SetBool("IsShouting", false);
                    Vampireanim.SetTrigger("IsHit");
                }
                else if (hit.collider.gameObject.tag == "VampHead")
                {
                    VampireHealth enemyhealth = hit.collider.gameObject.transform.root.GetComponentInChildren<VampireHealth>();
                    Vampireanim = hit.collider.gameObject.transform.root.GetComponentInChildren<Animator>();
                    Debug.Log("HitWithHead");
                    if (enemyhealth != null)
                    {
                        Debug.Log("Head");
                        enemyhealth.TakeDamage(100);

                    }
                    Vampireanim.SetBool("IsRunning", false);
                    Vampireanim.SetBool("IsAttacking", false);
                    Vampireanim.SetBool("IsAttacking2", false);
                    Vampireanim.SetBool("IsShouting", false);
                    Vampireanim.SetTrigger("IsHit");
                }
                else if (hit.collider.gameObject.tag == "VampArms")
                {
                    VampireHealth enemyhealth = hit.collider.gameObject.transform.root.GetComponentInChildren<VampireHealth>();
                    Vampireanim = hit.collider.gameObject.transform.root.GetComponentInChildren<Animator>();
                    Debug.Log("HitWithArms");
                    if (enemyhealth != null)
                    {
                        Debug.Log("Arms");
                        enemyhealth.TakeDamage(5);

                    }
                    Vampireanim.SetBool("IsRunning", false);
                    Vampireanim.SetBool("IsAttacking", false);
                    Vampireanim.SetBool("IsAttacking2", false);
                    Vampireanim.SetBool("IsShouting", false);
                    Vampireanim.SetTrigger("IsHit");
                }
                else if (hit.collider.gameObject.tag == "VampLegs")
                {
                    VampireHealth enemyhealth = hit.collider.gameObject.transform.root.GetComponentInChildren<VampireHealth>();
                    Vampireanim = hit.collider.gameObject.transform.root.GetComponentInChildren<Animator>();
                    Debug.Log("HitWithLegs");
                    if (enemyhealth != null)
                    {
                        Debug.Log("Legs");
                        enemyhealth.TakeDamage(5);

                    }
                    Vampireanim.SetBool("IsRunning", false);
                    Vampireanim.SetBool("IsAttacking", false);
                    Vampireanim.SetBool("IsAttacking2", false);
                    Vampireanim.SetBool("IsShouting", false);
                    Vampireanim.SetTrigger("IsHit");
                }

                ShotgunAnim.SetBool("IsShooting", true);
                

            }
        }

        else if ((ShotgunmagazineSize == 0) && (Input.GetKeyDown(KeyCode.R)))
        {
            if (ShotgunbulletsCollected > 8)
            {
                AudioClips[1].Play();
                ShotgunmagazineSize = 8;
                ShotgunbulletsCollected -= 8;
                ShotgunAnim.SetBool("IsReloading", true);
            }
            else
            {
                AudioClips[1].Play();
                ShotgunmagazineSize = ShotgunbulletsCollected;
                ShotgunbulletsCollected = 0;
                ShotgunAnim.SetBool("IsReloading", true);
            }
        }
        
    }

    void BulletSpawn()
    {
        int i = 0;
        foreach(Quaternion quat in pellets)
        {
            ShotgunParticle.Play();
            pellets[i] = Random.rotation;
            GameObject pels = Instantiate(pellet, ShotgunExit.position, ShotgunExit.rotation);
            pels.transform.rotation = Quaternion.RotateTowards(pels.transform.rotation, pellets[i], spreadAngle);
            pels.GetComponent<Rigidbody>().AddForce(pels.transform.forward * pelletFireVel);
            i++;

        }

    }

    void Aim()
    {
        float screenX = Screen.width / 2;
        float screenY = Screen.height / 2;

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector3(screenX, screenY));

        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point);
        }
    }
}
