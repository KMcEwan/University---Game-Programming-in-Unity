using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGController : MonoBehaviour
{

    public int SMGbulletsCollected;
    public int SMGmagazineSize;
    public int MaxSMGBulletCarry;

    public Rigidbody projectile;

    public float speed = 20;
    Animator Vampireanim;
    Animator SMGanim;
    public Camera cam;
    public GameObject gun;

    public float range = 100f;
    int VampireMask;
    RaycastHit hit;
    LineRenderer gunLine;

    private ParticleSystem SMGparticle;

    public AudioSource[] AudioClips = null;


    private void Awake()
    {
        //MaxSMGBulletCarry = 200;
        VampireMask = LayerMask.GetMask("Vampire");
    }

    void Start()
    {
        SMGanim = GameObject.FindWithTag("SMGArms").GetComponent<Animator>();
        SMGparticle = GameObject.FindWithTag("SMGMuzzleFlash").GetComponent<ParticleSystem>();
       
    }

    // Update is called once per frame
    void Update()
    {

        float screenX = Screen.width / 2;
        float screenY = Screen.height / 2;

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector3(screenX, screenY));

        if (((Input.GetMouseButtonDown(0)) && (SMGanim.GetBool("IsReloading") == false) && SMGmagazineSize > 0))
        {

            BulletSpawn();
            AudioClips[1].Play();
            if (Physics.Raycast(ray, out hit))
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
                        enemyhealth.TakeDamage(20);

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
                        enemyhealth.TakeDamage(50);

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
                SMGanim.SetBool("IsShooting", true);
            }
            SMGmagazineSize--;
        }
        else if ((SMGmagazineSize == 0) && (Input.GetKeyDown(KeyCode.R)))
        {
            if (SMGbulletsCollected > 30)
            {
                AudioClips[0].Play();
                SMGanim.SetBool("IsReloading", true);
                SMGmagazineSize = 30;
                SMGbulletsCollected -= 30;
            }
            else
            {
                AudioClips[0].Play();
                SMGanim.SetBool("IsReloading", true);
                SMGmagazineSize = SMGbulletsCollected;
                SMGbulletsCollected = 0;
            }
        }

    }



    void BulletSpawn()
    {
        SMGparticle.Play();
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, gun.transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        Destroy(instantiatedProjectile.gameObject, 3);

    }
}