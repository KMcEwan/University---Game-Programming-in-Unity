using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOnHit : MonoBehaviour {


    private void Start()
    {
   
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
          
        }

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Wall Hit");            
            Destroy(this.gameObject);
            Debug.Log("bULLET DELETION 4");
        }
        
        if (other.gameObject.tag == "EndBossSheild")
        {
            
            Destroy(this.gameObject);
            Debug.Log("bULLET DELETION 5");
        } 
    }
   
}




