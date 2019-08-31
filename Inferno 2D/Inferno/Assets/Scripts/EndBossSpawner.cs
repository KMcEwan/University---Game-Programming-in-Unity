using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossSpawner : MonoBehaviour {

    public GameObject Endboss;
    private GameObject SpawnedBoss;

    public bool isSpawned;
    // Use this for initialization
    void Start()
    {
        Debug.Log("running");
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void BossSpawn()
    {
        Debug.Log("Endboss spawn");
        if (!isSpawned)
        {
            var enemySpawnPoint = GameObject.Find("EndBossSpawner").transform;
            SpawnedBoss = Instantiate(Endboss, enemySpawnPoint.position, enemySpawnPoint.rotation) as GameObject;

        }
    }

    void Spawn()
    {
        if (Player.spawnVarRoom8 == 1)
        {
            Debug.Log("BOSS ROOM 8");
            BossSpawn();
        }
    }

}
