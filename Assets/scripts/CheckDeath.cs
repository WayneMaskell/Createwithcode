using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { if (other.CompareTag("Player"))
            other.GetComponent<Rigidbody>().isKinematic = false ;}
 
   

    
}
