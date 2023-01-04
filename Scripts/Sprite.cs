using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{
    private Player player;

    public Vector2 lookAt;
    public Vector2 lookUp;
    public Vector2 lookDown;

    public float velocityLerp;
    public float timeLerp;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

        lookUp   = new Vector2(1,  1).normalized;
        lookDown = new Vector2(1, -1).normalized;
    }

    void Update()
    {
        LookToDirection();
    }

    private void LookToDirection()
    {
        timeLerp += Time.deltaTime;

        if (player.Live)
        {
            float t = Mathf.Min(timeLerp * velocityLerp, 1);
            lookAt = Vector2.Lerp(lookUp, lookDown, t);

            transform.right = lookAt;
        }
    }
}
