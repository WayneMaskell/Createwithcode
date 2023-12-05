using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveFoward(player, speed);
    }

    private void MoveFoward(Transform player, float speed = 3.0f)
    {
        player.Translate(player.forward * speed * Time.deltaTime);
    }
}
