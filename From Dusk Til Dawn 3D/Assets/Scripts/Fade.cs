using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
    }

    void Update()
    {

        if (player.PlayerDead == true)
        {
            ScoreScript.scoreValue = 0;
            StartCoroutine(DoFade());
            Debug.Log("Fade");
        }

    }



    IEnumerator DoFade()
    {
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        
        while (canvasGroup.alpha < 1)
        {
            //yield return new WaitForSeconds(5);
            canvasGroup.alpha += Time.deltaTime / 50;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
    
}