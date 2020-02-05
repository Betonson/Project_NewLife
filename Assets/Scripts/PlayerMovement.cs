using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;

    [Range(0, 100f)][SerializeField] public float runSpeed = 60f;

    float horisontalMove = 0f;

    bool jump = false;
    void Start()
    {
        
    }

    void Update()
    {

        horisontalMove = Input.GetAxisRaw("Horisontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

    }

    private void FixedUpdate()
    {

        controller.Move(horisontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }
}
