using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

    public Sprite[] sprites;
    public Sprite[] spritesU;
    public Sprite[] spriteR;
    public Sprite[] spriteL;
    public Sprite[] Death;

    public float framesPerSecond;
    float lockPos = 0;
    Animator DemonAnimator;
    
    public Transform player;
    public Vector2 relativePoint;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
              
    }




    void Update()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
                index = index % sprites.Length;
                spriteRenderer.sprite = sprites[index];

        relativePoint = transform.InverseTransformPoint(player.position);
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        if (relativePoint.x < 0f && Mathf.Abs(relativePoint.x) > Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Right");
            spriteRenderer.sprite = spriteR[index];
            spriteRenderer.flipX = true;
        }
        if (relativePoint.x > 0f && Mathf.Abs(relativePoint.x) > Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Left");
            spriteRenderer.sprite = spriteL[index];
            spriteRenderer.flipX = false;
        }
        if (relativePoint.y > 0 && Mathf.Abs(relativePoint.x) < Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Under");
            spriteRenderer.sprite = spritesU[index];
           // DemonAnimator.SetBool("DemonUp", true);
        }
        if (relativePoint.y < 0 && Mathf.Abs(relativePoint.x) < Mathf.Abs(relativePoint.y))
        {
            Debug.Log("Above");
            spriteRenderer.sprite = sprites[index];
        }
        if (GetComponent<Lvl1Enemy>().Health <= 0)
        {
           
            
            spriteRenderer.sprite = Death[index];
            
        }
        
    }
}


