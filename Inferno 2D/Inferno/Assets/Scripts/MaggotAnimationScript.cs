using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaggotAnimationScript : MonoBehaviour
{


    public Sprite[] sprites;
    public Sprite[] spritesU;
    public Sprite[] spriteR;
    public Sprite[] spriteL;
    public Sprite[] Death;

    float speed = 2;
    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;

    public int MovementCheckVar = 0;
    float lockPos = 0;
    public int Timer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
        index = index % sprites.Length;
        spriteRenderer.sprite = sprites[index];

        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);

        Timer++;
        TimerCheck();
       
        if (MovementCheckVar == 0)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            spriteRenderer.sprite = sprites[index];
        }
        else
            if (MovementCheckVar == 1)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            spriteRenderer.sprite = spritesU[index];
        }

    }

    void TimerCheck()
    {
        if (Timer <= 200)
        {
            MovementCheckVar = 0;
        }
        else
        if ((Timer >= 201) && (Timer <= 401))
        {
            MovementCheckVar = 1;
        }
        else
        if (Timer >= 402)
        { 
            Timer = 0;
        }
    }
}
