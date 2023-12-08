using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2controller : MonoBehaviour
{
   
        public float horizontalInput;
        public float verticalInput;
        public float speed = 40f;
        public float rotateSpeed = 1f;
        public float defaultSpeed = 40f;
        public float sprintSpeed = 80f;
        public Rigidbody playerRb;
        // Start is called before the first frame update
        void Start()
        {
            playerRb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            GetInput();
            SetSpeed();
        }
        public void GetInput()
        {
            horizontalInput = Input.GetAxis("horizontal");
            verticalInput = Input.GetAxis("vertical");
        }

        private void FixedUpdate()
        {
            //MoveCarWithForceAndTorque();
            MoveCarWithPhysicsRotation();
        }

        private void MoveCarWithForceAndTorque()
        {
            if (verticalInput > 0.01f || verticalInput < -0.01f)
            {
                playerRb.AddForce(transform.forward * verticalInput * speed);

            }
            if (horizontalInput > 0.01f || horizontalInput < -0.01f)
            {
                playerRb.AddTorque(transform.up * verticalInput * rotateSpeed);

            }
        }

        public void SetSpeed()
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = sprintSpeed;
            }

            else { speed = defaultSpeed; }



        }
        private void MoveCarWithPhysicsRotation()
        {
            //Vector3 moveDirection = new Vector2(horizontalInput, verticalInput);
            Vector3 moveDirection = transform.forward * verticalInput;
            playerRb.MovePosition(playerRb.position + moveDirection * speed * Time.fixedDeltaTime);
            if (verticalInput > 0.01f || verticalInput < -0.01f)
            {
                float turnSpeed = horizontalInput * rotateSpeed * Time.fixedDeltaTime;
                Quaternion turnRotation = Quaternion.Euler(0f, turnSpeed, 0f);
                playerRb.MoveRotation(playerRb.rotation * turnRotation);
            }


        }
    


}
