using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolController : MonoBehaviour {

    public int PistolbulletsCollected = 0;
    public int PistolmagazineSize;
    public int MaximumPistolBulletCarry;

    public Rigidbody projectile;

    Animator Vampireanim;
    Animator Pistolanim;
    public Camera cam;
    public GameObject gun;

    public float speed = 20;
    public float FireRate = 0.5f;
    private float NextFire = 0.0f;

    public AudioSource[] AudioClips = null;

    private ParticleSystem Pistolparticle;

    private void Awake()
    {
        //MaximumPistolBulletCarry = 100;
    }

    void Start()
    {
        Pistolanim = GameObject.FindWithTag("PistolArms").GetComponent<Animator>();
        Pistolparticle = GameObject.FindWithTag("PistolMuzzleFlash").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        float screenX = Screen.width / 2;
        float screenY = Screen.height / 2;

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(new Vector3(screenX, screenY));

        if ((Input.GetMouseButtonDown(0)) && (PistolmagazineSize > 0) && (Time.time > NextFire))
        {
            NextFire = Time.time + FireRate;
            BulletSpawn();
            AudioClips[0].Play();
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
                    Pistolanim.SetBool("IsShooting", true);
            }
            
            PistolmagazineSize--;
            
        }
        else if ((PistolmagazineSize == 0) && (Input.GetKeyDown(KeyCode.R)))
        {
            if (PistolbulletsCollected > 7)
            {
                AudioClips[1].Play();
                Pistolanim.SetBool("IsReloading", true);
                PistolmagazineSize = 7;
                PistolbulletsCollected -= 7;
            }
            else
            {
                AudioClips[1].Play();
                Pistolanim.SetBool("IsReloading", true);
                PistolmagazineSize = PistolbulletsCollected;
                PistolbulletsCollected = 0;
            }
        }
    }

    void BulletSpawn()
    {
        Pistolparticle.Play();
        Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, gun.transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
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
