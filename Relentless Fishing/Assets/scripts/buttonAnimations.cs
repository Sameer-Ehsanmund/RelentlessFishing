using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnimations : MonoBehaviour
{

    public Animator anim;

    public GameObject startBut;
    public GameObject pauseBut;
    public GameObject gameWONBut;
    public GameObject gameText;
    public GameObject fishCollectedText;
    public GameObject FCS;
    public GameObject Pausepanel;

    public void Update()
    {

        if (GameObject.FindGameObjectsWithTag("fish").Length == 0)
        {
        
            StartCoroutine(onGameWon());
        }
    }

    IEnumerator onGameWon()
    {
      
        yield return new WaitForSeconds(1);
        Time.timeScale = 0;
        Debug.Log("Game End");
        gameWONBut.active = true;
    }

    public void onGameStart()
    {

        anim.enabled = true;
        startBut.active = false;
        gameText.active = false;
        FCS.GetComponent<fishCollectionSystem>().startingCoroutine();        
        StartCoroutine(fishcollectionLabel());
    }

    IEnumerator fishcollectionLabel()
    {

        yield return new WaitForSeconds(4);
        fishCollectedText.active = true;
        pauseBut.active = true;
    }

    public void onPauseGame()
    {

        Time.timeScale = 0;
        Pausepanel.active = true;
    }

    public void onResumeGame()
    {

        Pausepanel.active = false;
        Time.timeScale = 1;       
    }

    public void onExitGame()
    {

        Application.Quit();
    }
}
