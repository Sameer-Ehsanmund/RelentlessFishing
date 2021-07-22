using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnimations : MonoBehaviour
{

    public Animator anim;

    public GameObject startBut;
    public GameObject gameText;
    public GameObject fishCollectedText;
    public GameObject FCS;

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
    }
}
