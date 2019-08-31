using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePitSpawner : MonoBehaviour
{
    
    public GameObject FirePit;
    private GameObject SpawnedFire1;
    private GameObject SpawnedFire2;
    private GameObject SpawnedFire3;
    private GameObject SpawnedFire4;
    private GameObject SpawnedFire5;
    private GameObject SpawnedFire6;
    private GameObject SpawnedFire7;
    private GameObject SpawnedFire8;
    private GameObject SpawnedFire9;
    private GameObject SpawnedFire10;
    private GameObject SpawnedFire11;
    private GameObject SpawnedFire12;
    private GameObject SpawnedFire13;
    private GameObject SpawnedFire14;
    private GameObject SpawnedFire15;
    private GameObject SpawnedFire16;
    private GameObject SpawnedFire17;
    private GameObject SpawnedFire18;
    private GameObject SpawnedFire19;
    private GameObject SpawnedFire20;
    private GameObject SpawnedFire21;
    private GameObject SpawnedFire22;
    private GameObject SpawnedFire23;
    private GameObject SpawnedFire24;



    public bool FirePitIsSpawned = false;

    private void Start()
    {
        Spawn(); 
    }

    private void Update()
    {
        

    }

    void Spawn()
    {

      
        if (!FirePitIsSpawned)
        {
            var FireSpawnPoint = GameObject.Find("Rm_1_FireSpawner").transform;
            SpawnedFire1 = Instantiate(FirePit, FireSpawnPoint.position, FireSpawnPoint.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint2 = GameObject.Find("Rm_1_FireSpawner2").transform;
            SpawnedFire2 = Instantiate(FirePit, FireSpawnPoint2.position, FireSpawnPoint2.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint3 = GameObject.Find("Rm_2_FireSpawner1").transform;
            SpawnedFire3 = Instantiate(FirePit, FireSpawnPoint3.position, FireSpawnPoint3.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint4 = GameObject.Find("Rm_2_FireSpawner2").transform;
            SpawnedFire4 = Instantiate(FirePit, FireSpawnPoint4.position, FireSpawnPoint4.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint5 = GameObject.Find("Rm_3_FireSpawner1").transform;
            SpawnedFire5 = Instantiate(FirePit, FireSpawnPoint5.position, FireSpawnPoint5.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint6 = GameObject.Find("Rm_3_FireSpawner2").transform;
            SpawnedFire6 = Instantiate(FirePit, FireSpawnPoint6.position, FireSpawnPoint6.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint7 = GameObject.Find("Rm_4_FireSpawner1").transform;
            SpawnedFire7 = Instantiate(FirePit, FireSpawnPoint7.position, FireSpawnPoint7.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint8 = GameObject.Find("Rm_4_FireSpawner2").transform;
            SpawnedFire8 = Instantiate(FirePit, FireSpawnPoint8.position, FireSpawnPoint8.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint9 = GameObject.Find("Rm_5_FireSpawner1").transform;
            SpawnedFire9 = Instantiate(FirePit, FireSpawnPoint9.position, FireSpawnPoint9.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint10 = GameObject.Find("Rm_5_FireSpawner2").transform;
            SpawnedFire10 = Instantiate(FirePit, FireSpawnPoint10.position, FireSpawnPoint10.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint11 = GameObject.Find("Rm_6_FireSpawner1").transform;
            SpawnedFire11 = Instantiate(FirePit, FireSpawnPoint11.position, FireSpawnPoint11.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint12 = GameObject.Find("Rm_6_FireSpawner2").transform;
            SpawnedFire12 = Instantiate(FirePit, FireSpawnPoint12.position, FireSpawnPoint12.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint13 = GameObject.Find("Rm_7_FireSpawner1").transform;
            SpawnedFire13 = Instantiate(FirePit, FireSpawnPoint13.position, FireSpawnPoint13.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint14 = GameObject.Find("Rm_7_FireSpawner2").transform;
            SpawnedFire14 = Instantiate(FirePit, FireSpawnPoint14.position, FireSpawnPoint14.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint15 = GameObject.Find("Rm_8_FireSpawner1").transform;
            SpawnedFire15 = Instantiate(FirePit, FireSpawnPoint15.position, FireSpawnPoint15.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint16 = GameObject.Find("Rm_8_FireSpawner2").transform;
            SpawnedFire16 = Instantiate(FirePit, FireSpawnPoint16.position, FireSpawnPoint16.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint17 = GameObject.Find("Rm_9_FireSpawner1").transform;
            SpawnedFire17 = Instantiate(FirePit, FireSpawnPoint17.position, FireSpawnPoint17.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint18 = GameObject.Find("Rm_9_FireSpawner2").transform;
            SpawnedFire18 = Instantiate(FirePit, FireSpawnPoint18.position, FireSpawnPoint18.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint19 = GameObject.Find("Rm_10_FireSpawner1").transform;
            SpawnedFire19 = Instantiate(FirePit, FireSpawnPoint19.position, FireSpawnPoint19.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint20 = GameObject.Find("Rm_10_FireSpawner2").transform;
            SpawnedFire20 = Instantiate(FirePit, FireSpawnPoint20.position, FireSpawnPoint20.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint21 = GameObject.Find("Rm_11_FireSpawner1").transform;
            SpawnedFire21 = Instantiate(FirePit, FireSpawnPoint21.position, FireSpawnPoint21.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint22 = GameObject.Find("Rm_11_FireSpawner2").transform;
            SpawnedFire22 = Instantiate(FirePit, FireSpawnPoint22.position, FireSpawnPoint22.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint23 = GameObject.Find("Rm_12_FireSpawner1").transform;
            SpawnedFire23 = Instantiate(FirePit, FireSpawnPoint23.position, FireSpawnPoint23.rotation) as GameObject;
            FirePitIsSpawned = true;

            var FireSpawnPoint24 = GameObject.Find("Rm_12_FireSpawner2").transform;
            SpawnedFire24 = Instantiate(FirePit, FireSpawnPoint24.position, FireSpawnPoint24.rotation) as GameObject;
            FirePitIsSpawned = true;

    
        }
    }

    
}

