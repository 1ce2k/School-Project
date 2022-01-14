using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContol : MonoBehaviour
{
    public float speed = 4.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDir = Vector3.zero;
    private CharacterController controller;
#pragma warning disable IDE0051 // Remove unused private members
    void Start()
#pragma warning restore IDE0051 // Remove unused private members
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
#pragma warning disable IDE0051 // Remove unused private members
    void Update()
#pragma warning restore IDE0051 // Remove unused private members
    {
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
        }

        if (Input.GetKeyUp(KeyCode.Space) && controller.isGrounded)
        {
            moveDir.y = jumpSpeed;
        }

        moveDir.y -= gravity * Time.deltaTime;

        controller.Move(moveDir * Time.deltaTime);
    }
}
