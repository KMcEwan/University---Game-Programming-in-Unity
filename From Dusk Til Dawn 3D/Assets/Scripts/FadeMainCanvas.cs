using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeMainCanvas : MonoBehaviour {

    Player player;

    void Start ()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (player.PlayerDead == true)
        {
            StartCoroutine(DoFade());
            Debug.Log("Fade");
        }
    }
    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            //yield return new WaitForSeconds(5);
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
    
}
