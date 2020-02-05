using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour { 

    //public CharacterController2D controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            Debug.Log("Left");
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            Debug.Log("Right");
        }
        else if (Input.GetAxisRaw("Vertical") == -1)
        {
            Debug.Log("Up");
        }
        else if (Input.GetAxisRaw("Vertical") == 1)
        {
            Debug.Log("Down");
        }
        else if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
        }
    }
}
