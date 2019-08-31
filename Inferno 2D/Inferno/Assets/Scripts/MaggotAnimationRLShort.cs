using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaggotAnimationRLShort : MonoBehaviour {


    public Sprite[] spriteR;
    public Sprite[] spriteL;
    //public Sprite[] Death;
    float lockPos = 0;
    float speed = 2;
    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;

    public int MovementCheckVar = 0;

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
        index = index % spriteR.Length;
        spriteRenderer.sprite = spriteR[index];
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);


        Timer++;
        TimerCheck();

        if (MovementCheckVar == 0)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            spriteRenderer.sprite = spriteL[index];
        }
        else
            if (MovementCheckVar == 1)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            spriteRenderer.sprite = spriteR[index];
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
