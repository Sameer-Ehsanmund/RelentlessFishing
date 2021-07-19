using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookMovement : MonoBehaviour
{

    public CharacterController cc;

    Vector3 direction;

    public float speed;

    public GameObject fishBeingCollected;

    public void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontal, vertical, 0f).normalized;

        if (direction.magnitude >= 0.1f)
        {

            cc.Move(direction * speed * Time.deltaTime);
        }

        if (direction.magnitude <= 0.1f)
        {

            cc.Move(direction * speed * Time.deltaTime);
        }
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {

        GameObject fish = GameObject.FindWithTag("fish");
   
        if (hit.transform.tag == "fish")
        {

            fishCollectionSystem fishCollected = fishBeingCollected.GetComponent<fishCollectionSystem>().fishCollected += 1;
            Destroy(hit.gameObject);
        }
    }
}
