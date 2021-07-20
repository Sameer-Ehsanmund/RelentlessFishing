using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookMovement : MonoBehaviour
{

    float mZCoord;

    Vector3 mOffset;

    public GameObject FCS;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        }

        if (Input.GetMouseButton(0))
        {

            transform.position = new Vector3(GetMouseAsWorldPoint().x + mOffset.x, GetMouseAsWorldPoint().y + mOffset.y, transform.position.z);
        }
    }

    Vector3 GetMouseAsWorldPoint()
    {

        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    public void OnCollisionEnter(Collision collision)
    {

        GameObject fish = GameObject.FindWithTag("fish");

        if (collision.transform.tag == "fish")
        {

            Debug.Log("hitting");
            Destroy(collision.gameObject);
            FCS.GetComponent<fishCollectionSystem>().fishCollected += 1;
        }
    }
}
