using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBossFireBallFiring : MonoBehaviour {
    public GameObject Fireball;

    void Start()
    {
        InvokeRepeating("FireEnemyBullet", 1f, 2f);
    }

    private void Update()
    {

    }

    void FireEnemyBullet()
    {
        Debug.Log("Bullet Fired");
        GameObject Player = GameObject.Find("Player");

        if (Player != null)
        {
            GameObject bullet = (GameObject)Instantiate(Fireball);
            bullet.transform.position = transform.position;
            Vector2 direction = Player.transform.position - bullet.transform.position;
            bullet.GetComponent<FireBallBullet>().SetDirection(direction);
            
        }
    }


}