using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;
    public Sprite sprite;

    public Vector2 yVelocity;
    public float maxHeight;
    public float jumpSpeed;
    public float timeToPeak;

    public float gravity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        GravityCalc();
    }

    void Update()
    {
        if(sprite.live)
        {

            yVelocity += gravity * Time.deltaTime * Vector2.down;

            if (Input.GetKeyDown("space"))
            {
                yVelocity = jumpSpeed * Vector2.up;
            } 

            controller.Move(yVelocity);
        }
    }

    private void GravityCalc()
    {
        gravity = (2 * maxHeight) / (Mathf.Pow(timeToPeak, 2));
        jumpSpeed = gravity * timeToPeak;
    }
}
