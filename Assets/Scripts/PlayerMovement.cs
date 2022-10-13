using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 4f;
    Vector3 forward, right;

    void Update()
    {

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        if (direction.magnitude > 0.1f)
        {
            Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
            Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxisRaw("Vertical");

            Vector3 heading = Vector3.Normalize(rightMovement + upMovement);
            transform.forward = heading;
            transform.position += heading * moveSpeed * Time.deltaTime;
        }

    }
}
