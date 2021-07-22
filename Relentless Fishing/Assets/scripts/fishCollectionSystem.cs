using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishCollectionSystem : MonoBehaviour
{

    public int fishCollected;

    bool useGUI = false;

    GUIStyle guiStyle = new GUIStyle();

    public void startingCoroutine()
    {

        StartCoroutine(usingGUI());
    }

   IEnumerator usingGUI()
    {

        yield return new WaitForSeconds(4);
        useGUI = true;
    }

    void OnGUI()
    {

        if (useGUI == true)
        {

            GUI.color = Color.black;
            guiStyle.fontSize = 30;
            GUI.Label(new Rect(270, 40, 100, 100), ("" + fishCollected), guiStyle);
        }           
    }
}
