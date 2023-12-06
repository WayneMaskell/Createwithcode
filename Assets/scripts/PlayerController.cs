using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   // public Camera firstPerson;
   // public Camera thirdPerson;
    public float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        //thirdPerson.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.GetKeyDown(KeyCode.V))
        //{
          //  firstPerson.enabled = !firstPerson.enabled;
           // thirdPerson.enabled = !thirdPerson.enabled;


       // }
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
