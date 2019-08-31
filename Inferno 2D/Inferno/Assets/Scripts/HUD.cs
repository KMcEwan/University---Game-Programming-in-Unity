using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] Hearts;
    private Player player;
    public Image HeartsUI;


    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        HeartsUI.sprite = Hearts[player.PlayerLives];
	}
}
