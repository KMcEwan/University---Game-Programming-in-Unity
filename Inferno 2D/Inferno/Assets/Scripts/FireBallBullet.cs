using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallBullet : MonoBehaviour
{
    public GameObject fireball;
    public Sprite[] sprites;

    float speed;
    Vector2 _direction;
    bool isReady;

    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        speed = 5f;
        isReady = false;    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        fireball = GameObject.FindGameObjectWithTag("EnemyBullet");
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;
        isReady = true;
    }

    private void Update()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
        index = index % sprites.Length;
        spriteRenderer.sprite = sprites[index];

        if (isReady)
        {
            Vector2 position = transform.position;
            position += _direction * speed * Time.deltaTime;
            transform.position = position;

        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(fireball);
            Debug.Log("Fireball deletion");
            
        }

        if (other.gameObject.tag == "Wall")
        {
            Debug.Log("Wall Hit");
            Destroy(fireball);
            Debug.Log("Fireball deletion");
        }

        if (other.gameObject.tag == "Door")
        {
            Debug.Log("Wall Hit");
            Destroy(fireball);
            Debug.Log("Fireball deletion");
        }
    }
}