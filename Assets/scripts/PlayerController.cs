using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // public Camera firstPerson;
    // public Camera thirdPerson;
    private float horizontalInput;
    private float verticalInput;
    private float speed = 15f;
    
    private float rotateSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        //thirdPerson.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();





        //rotateplayer(transform, rotateSpeed);
      
        //move the vehicle forward
       // transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }
    private void MovePlayer(Transform player, float speed = 10f) 
    {
        player.Translate(player.forward * speed * verticalInput * Time.deltaTime);   
        player.Translate(player.right * speed * horizontalInput * Time.deltaTime);

        
    
    
    }

    private void rotateplayer(Transform player,float rotateSpeed = 30.0f, float speed = 10f) 
    
    {
        player.Translate(Vector3.forward * speed * verticalInput *Time.deltaTime);  
        if (verticalInput > 0.01f || verticalInput < -0.01f) 
        {
            player.Rotate(Vector3.up, rotateSpeed * horizontalInput * Time.deltaTime);


        }
        if(Input.GetKey(KeyCode.LeftShift)) 
        {
            player.Translate(Vector3.forward * (speed * 2) * verticalInput * Time.deltaTime);
        }
         
    
    }
}
