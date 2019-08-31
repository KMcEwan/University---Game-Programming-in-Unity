using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopEnemySpawner : MonoBehaviour {

    public EnemySpawner SpawnController;
    public int Day;
    public bool AmmoSpawn;

    private void Awake()
    {
        Day = 1;
    }

    void Start ()
    {
        
	}
   
	void Update ()
    {
        Debug.Log("Ammo spawn" + AmmoSpawn);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MoonObject")
        {
            SpawnController.Spawn = false;
            AmmoSpawn = true;
            Day++;
        }

    }


}
