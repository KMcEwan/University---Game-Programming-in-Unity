using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePitAnimation : MonoBehaviour {

    public Sprite[] sprites;
    
    public float framesPerSecond;
    private SpriteRenderer spriteRenderer;


    void Start ()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
        index = index % sprites.Length;
        spriteRenderer.sprite = sprites[index];
    }
}
