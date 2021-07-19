using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishCollectionSystem : MonoBehaviour
{

    public int fishCollected = 0;

    void OnGUI()
    {

        GUI.color = Color.black;
        GUI.Label(new Rect(20, 20, 100, 50), ("Total Fish: " + fishCollected));
    }
}
