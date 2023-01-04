using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool Live { get; set; }

    public Vector2 yVelocity;
    public float maxHeight;
    public float jumpSpeed;
    public float timeToPeak;
    public float gravity;

    private Sprite sprite;

    void Awake()
    {
        sprite = GameObject.Find("Sprite").GetComponent<Sprite>();
        GravityCalc();
        Live = false;
    }

    void Update()
    {
        if(Live)
        {
            yVelocity += gravity * Time.deltaTime * Vector2.down;
            transform.Translate(yVelocity);
        }
    }

    private void GravityCalc()
    {
        gravity = (2 * maxHeight) / (Mathf.Pow(timeToPeak, 2));
        jumpSpeed = gravity * timeToPeak;
    }

    public void Jump()
    {
        Live = true;
        yVelocity = jumpSpeed * Vector2.up;
        sprite.timeLerp = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Live = false;
    }
}
