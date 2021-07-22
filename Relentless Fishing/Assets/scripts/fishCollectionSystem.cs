using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fishCollectionSystem : MonoBehaviour
{

    public int fishCollected;

    public void Update()
    {

        OnGUI();
    }

    void OnGUI()
    {

        GUI.color = Color.black;
        GUI.Label(new Rect(20, 20, 100, 50), ("" + fishCollected));
    }
        

}
