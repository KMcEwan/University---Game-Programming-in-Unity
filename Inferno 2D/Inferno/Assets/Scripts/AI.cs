using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    Transform Player;
    float speed = 1f;


    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (GetComponent<Lvl1Enemy>().Health > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
             Vector3 direction = Player.position - this.transform.position;
             float angle = Mathf.Atan2(direction.y, direction.x);
             this.transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90); 
        }
    }

    
}

