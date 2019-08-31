using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{

    public GameObject Player;


    // Use this for initialization
    void Start()
    {
        var PlayerSpawn = GameObject.Find("PlayerSpawnPoint").transform;
        Player = Instantiate(Player, PlayerSpawn.position, PlayerSpawn.rotation) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
