using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndBossHealth : MonoBehaviour
{


    public int Timer;
    private Text TempText;
    public int _EndBossHealth = 100;
    float lockPos = 0;

    void Start()
    {
        TempText = GameObject.Find("Paused").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        HealthCheck();
        TimerCheck();
        Debug.Log("ENDBOSS HEALTH" + _EndBossHealth);
    }

    void HealthCheck()
    {
        if (_EndBossHealth <= 0)
        {
            
            Debug.Log("END BOSS DEAD");
            
             Time.timeScale = 0f;
             TempText.text = ("Level clear");
             Timer++;
             
        }
    }
    void Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void TimerCheck()
    {
        if (Timer == 100)
        {
            Time.timeScale = 1f;
            Debug.Log("SceneChange");
            Scene();
        }
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            _EndBossHealth -= 10;
            Debug.Log("bELLET DELETION 2");

        }

       

    }
}
