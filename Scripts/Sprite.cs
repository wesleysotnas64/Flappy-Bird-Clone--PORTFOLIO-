using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour
{

    public bool live;
    public Vector2 lookAt;
    public Vector2 lookUp;
    public Vector2 lookDown;

    public float velocityLerp;
    public float timeLerp;

    void Awake()
    {
        live = false;
        lookUp   = new Vector2(1,  1).normalized;
        lookDown = new Vector2(1, -1).normalized;
    }

    void Update()
    {
        timeLerp += Time.deltaTime;
        if (Input.GetKeyDown("space"))
        {
            live = true;
            timeLerp = 0;
        }

        if (live)
        { 
            float t = Mathf.Min(timeLerp * velocityLerp, 1);
            lookAt = Vector2.Lerp(lookUp, lookDown, t);

            transform.right = lookAt;
        }
    }
}
