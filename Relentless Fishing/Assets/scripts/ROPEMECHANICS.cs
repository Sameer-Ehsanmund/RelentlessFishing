using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROPEMECHANICS : MonoBehaviour
{

    Vector3 mouseWorldPosition;
    RaycastHit raycastHit;
 
 void Update()
    {
        DestroyTile();
    }

    void DestroyTile()
    {
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.DrawLine(transform.position, mouseWorldPosition, Color.red);
    }
}
