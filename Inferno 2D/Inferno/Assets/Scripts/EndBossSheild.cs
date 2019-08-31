using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossSheild : MonoBehaviour
{

    public int SheildHealth = 100;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HealthChecker();
        Debug.Log("Sheild Health" + SheildHealth);
    }

    void HealthChecker()
    {
        if (SheildHealth <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("sHEILD DELETION");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            SheildHealth -= 10;
        }

    }
}
