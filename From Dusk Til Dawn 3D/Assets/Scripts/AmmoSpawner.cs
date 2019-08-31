using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour {

    public StopEnemySpawner stopEnemySpawner;

    public GameObject SMGAmmoSpawn;
    public GameObject SMGAmmo;
    public bool IsCreatedSMGAmmoSpawn;
   public int RandomNumberForAmmoSpawn;
    //////////////////////////////////////////////////////////// Spawn Location 1
    public List<GameObject> spawnPositions;
    public List<GameObject> spawnObjects;
    GameObject[] currentAmmo;
    //////////////////////////////////////////////////////////// Spawn Location 2
    public List<GameObject> spawnPositions2;
    GameObject[] currentAmmo2;
    //////////////////////////////////////////////////////////// Spawn Location 3
    public List<GameObject> spawnPositions3;
    GameObject[] currentAmmo3;
    //////////////////////////////////////////////////////////// Spawn Location 4
    public List<GameObject> spawnPositions4;
    GameObject[] currentAmmo4;
    //////////////////////////////////////////////////////////// Spawn Location 5
    public List<GameObject> spawnPositions5;
    GameObject[] currentAmmo5;



    void Start ()
    {
		
	}

    void Awake()
    {
        currentAmmo = new GameObject[spawnPositions.Count];
        currentAmmo2 = new GameObject[spawnPositions2.Count];
        currentAmmo3 = new GameObject[spawnPositions3.Count];
        currentAmmo4 = new GameObject[spawnPositions4.Count];
        currentAmmo5 = new GameObject[spawnPositions5.Count];
    }

    // Update is called once per frame
    void Update ()
    {
        SpawnChecker();
        Debug.Log("Random number for ammo spawn = " + RandomNumberForAmmoSpawn);
    }

    void SpawnChecker()
    {
        if (stopEnemySpawner.AmmoSpawn == true)
        {
            RandomNumberForAmmoSpawn = Random.Range(1, 5);
            if (RandomNumberForAmmoSpawn == 1)
            {
                SpawnObjects();
            }
            
            if (RandomNumberForAmmoSpawn == 2)
            {
                SpawnObjectsPoint2();
            }

            if (RandomNumberForAmmoSpawn == 3)
            {
                SpawnObjectsPoint3();
            }

            if (RandomNumberForAmmoSpawn == 4)
            {
                SpawnObjectsPoint4();
            }

            if (RandomNumberForAmmoSpawn == 5)
            {
                SpawnObjectsPoint5();
            }
            stopEnemySpawner.AmmoSpawn = false;
        }
    }


   void SpawnObjects()
   {
       for (int i = 0; i < currentAmmo.Length; ++i)
           {
                if (currentAmmo[i] != null) continue;
            int selection = Random.Range(0, spawnObjects.Count);
            GameObject newAmmo = Instantiate(spawnObjects[selection], spawnPositions[i].transform.position, spawnPositions[i].transform.rotation);
            currentAmmo[i] = newAmmo;
            }
   }

    void SpawnObjectsPoint2()
    {
        for (int i = 0; i < currentAmmo2.Length; ++i)
        {
            if (currentAmmo2[i] != null) continue;
            int selection = Random.Range(0, spawnObjects.Count);
            GameObject newAmmo2 = Instantiate(spawnObjects[selection], spawnPositions2[i].transform.position, spawnPositions2[i].transform.rotation);
            currentAmmo2[i] = newAmmo2;
        }
    }

    void SpawnObjectsPoint3()
    {
        for (int i = 0; i < currentAmmo3.Length; ++i)
        {
            if (currentAmmo3[i] != null) continue;
            int selection = Random.Range(0, spawnObjects.Count);
            GameObject newAmmo3 = Instantiate(spawnObjects[selection], spawnPositions3[i].transform.position, spawnPositions3[i].transform.rotation);
            currentAmmo3[i] = newAmmo3;
        }
    }
    void SpawnObjectsPoint4()
    {
        for (int i = 0; i < currentAmmo4.Length; ++i)
        {
            if (currentAmmo4[i] != null) continue;
            int selection = Random.Range(0, spawnObjects.Count);
            GameObject newAmmo4 = Instantiate(spawnObjects[selection], spawnPositions4[i].transform.position, spawnPositions4[i].transform.rotation);
            currentAmmo4[i] = newAmmo4;
        }
    }

    void SpawnObjectsPoint5()
    {
        for (int i = 0; i < currentAmmo5.Length; ++i)
        {
            if (currentAmmo5[i] != null) continue;
            int selection = Random.Range(0, spawnObjects.Count);
            GameObject newAmmo5 = Instantiate(spawnObjects[selection], spawnPositions5[i].transform.position, spawnPositions5[i].transform.rotation);
            currentAmmo5[i] = newAmmo5;
        }
    }
}

