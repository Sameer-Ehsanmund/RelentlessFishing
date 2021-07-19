using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookMovement : MonoBehaviour
{

    private CharacterController cc;

    public Vector3 direction;

    public float speed;
    private float timeToDestroyFish = 1f;

    void Start()
    {
        

    }

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

        if (hit.transform.tag == "fish")
        {

            Destroy(gameObject.tag == "fish", timeToDestroyFish);
        }
    }
}
