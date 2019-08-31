using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampireSpawn : MonoBehaviour {

    public Transform prefab;
    public int VampCounter;
    public int RandomRangeAmountZ;
    public int RandomRangeAmountX;

    StopEnemySpawner stopenemyspawner;
    
   
    void Start()
    {
        stopenemyspawner = GameObject.FindWithTag("MoonTriggerStopSpawn").GetComponent<StopEnemySpawner>();
    }
    private void Update()
    {
        if (VampCounter <4)
        {
            VampSpawn();
        }
        Debug.Log("Vampire Amount " + VampCounter);
        Debug.Log("Day " + stopenemyspawner.Day);
    }

    void VampSpawn()
    {
        RandomRangeAmountZ = Random.Range(-77, 5);
        RandomRangeAmountX = Random.Range(-23, 52);
        if (stopenemyspawner.Day < 3)
        for (int i = 0; i < 4; i++)
        {
           RandomRangeAmountZ = Random.Range(-77, 5);
           RandomRangeAmountX = Random.Range(-23, 52);
           Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
           VampCounter++;          
        } 
        else 
        if (stopenemyspawner.Day >= 3 && stopenemyspawner.Day <6 )
            for (int i = 0; i < 8; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 6 && stopenemyspawner.Day < 9)
            for (int i = 0; i < 12; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 9 && stopenemyspawner.Day < 12)
            for (int i = 0; i < 16; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 12 && stopenemyspawner.Day < 15)
            for (int i = 0; i < 20; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 15 && stopenemyspawner.Day < 18)
            for (int i = 0; i < 24; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 18 && stopenemyspawner.Day < 21)
            for (int i = 0; i < 28; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 21 && stopenemyspawner.Day < 24)
            for (int i = 0; i < 32; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 24 && stopenemyspawner.Day < 27)
            for (int i = 0; i < 36; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 27 && stopenemyspawner.Day < 30)
            for (int i = 0; i < 40; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
        else
        if (stopenemyspawner.Day >= 30)
            for (int i = 0; i < 56; i++)
            {
                RandomRangeAmountZ = Random.Range(-77, 5);
                RandomRangeAmountX = Random.Range(-23, 52);
                Instantiate(prefab, new Vector3(RandomRangeAmountX, 0, RandomRangeAmountZ), Quaternion.identity);
                VampCounter++;
            }
    }
}
