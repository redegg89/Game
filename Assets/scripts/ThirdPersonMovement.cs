﻿using API;
using Global;
using UnityEngine;

namespace Player
{
    public class ThirdPersonMovement : MonoBehaviour
    {
        public CharacterController controller;
        public Transform cam;
        public float speed = 12f;
        public float TurnTime = 0.1f;
        float TurnSmoothVelocity;
        public float gravity = -35f;
        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;
        float yVelocity;
        float WalkSlow;
        float WalkSlowVolx;
        float WalkSlowVolz;
        byte JumpHeight;

        Vector3 Velocity;
        bool isGrounded;
        // Update is called once per frame
        void Update()
        {

            WalkSlow = 0.1f;
            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
            SetJumpHeight(15);
            if (isGrounded && Velocity.y < 0)
            {
                Velocity.y = -1f;
            }
            //Movement
            float horizontal = Input.GetAxisRaw("Vertical");        //controller
            float vertical = Input.GetAxisRaw("Horizontal");

            float KBHori = Input.GetAxisRaw("Keyboard W");      //keyboard
            float KBVert = Input.GetAxisRaw("Keyboard A");
            Vector3 KBdirection = new Vector3(KBHori, 0f, KBVert).normalized;
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
            yVelocity = Velocity.y;
            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle + 270, ref TurnSmoothVelocity, TurnTime);
                transform.rotation = Quaternion.Euler(0f, Angle, 0f);

                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                Velocity = moveDirection.normalized * speed;
                Velocity.y = yVelocity;
            }
            if (KBdirection.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(KBdirection.z, KBdirection.x) * Mathf.Rad2Deg + cam.eulerAngles.y;
                float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle + 270, ref TurnSmoothVelocity, TurnTime);
                transform.rotation = Quaternion.Euler(0f, Angle, 0f);

                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                Velocity = moveDirection.normalized * speed;
                Velocity.y = yVelocity;
            }
            if (direction.magnitude == 0 & KBdirection.magnitude == 0)
            {
                Velocity.x = Mathf.SmoothDamp(Velocity.x, 0, ref WalkSlowVolx, WalkSlow);
                Velocity.z = Mathf.SmoothDamp(Velocity.z, 0, ref WalkSlowVolz, WalkSlow);
            }
            Velocity.y += gravity * Time.deltaTime;
            controller.Move(Velocity * Time.deltaTime);

            //Basic controls
            bool A = Input.GetButtonDown("Submit");
            if (A == true)
            {
                Jump();
            }
            float DpadUp = Input.GetAxisRaw("DpadUp");
            if (DpadUp >= 0.1f)
            {
                speed = speed + 1;
            }
            if (DpadUp <= -0.1f)
            {
                speed = speed - 1;
            }

            Cursor.visible = false;
        }
        //Functions
        public void Jump()
        {
            Velocity.y = JumpHeight;
        }

        public void SetJumpHeight(byte HeightChange)
        {
            JumpHeight = HeightChange;
        }
    }
}
