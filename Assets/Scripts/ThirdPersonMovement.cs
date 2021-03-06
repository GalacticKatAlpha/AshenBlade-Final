using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Animator anim;

    public float speed = 6f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Run");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("Idle");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("Attack");
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetTrigger("AttackToIdle");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            anim.SetTrigger("Attack2");
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            anim.SetTrigger("AttackToIdle2");
        }

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = - 2f;
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z)* Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        if(Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
