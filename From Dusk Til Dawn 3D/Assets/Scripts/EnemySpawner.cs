using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public bool Spawn = false;
   // public VampireSpawn vampireSpawn;
    public GameObject Spawner1;
    public GameObject Spawner2;
    public GameObject Spawner3;
    public GameObject Spawner4;

    public AudioSource[] AudioClips = null;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Spawn == true)
        {
            Spawner1.gameObject.SetActive(true);
            //Spawner2.gameObject.SetActive(true);
        }
        else
        {
            Spawner1.gameObject.SetActive(false);
            //Spawner2.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MoonObject")
        {
            AudioClips[0].Play();
            Spawn = true;            
        }
    }

    

}
