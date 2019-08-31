using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaggotDeathScript : MonoBehaviour
{
    public GameObject HealthPickUp;

    
    public int MaggotHealth = 100;
    public float DropRate = 0.1f;
    public bool HealthIsCreated = false;

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        Debug.Log("Maggot Health" + MaggotHealth);
		if (MaggotHealth <= 0)
        {
            
            ScoreScript.scoreValue += 2;
            Destroy(this.gameObject);
            FindObjectOfType<AudioManager>().Play("MaggotSquish");
            if (Random.Range(0f, 1f) <= DropRate)
            {
                if (!HealthIsCreated)
                {
                    Instantiate(HealthPickUp, transform.position, transform.rotation);
                    HealthIsCreated = true;
                }
            }
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
            Destroy(other.gameObject);
            MaggotHealth -= 25;
            Debug.Log("bULLET DELETION 3");

        }

    }
    
}
