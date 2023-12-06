using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchBool : MonoBehaviour
{
    public Camera firstPerson;
    public Camera thirdPerson;
    
    // Start is called before the first frame update
    void Start()
    {
        firstPerson.enabled = false;
        thirdPerson.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)) 
        {
            firstPerson.enabled = !firstPerson.enabled;
            thirdPerson.enabled = !thirdPerson.enabled;
        
        
        }
    }
}
