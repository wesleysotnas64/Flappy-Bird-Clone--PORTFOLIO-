using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float xVelocity;
    private float current;
    public Renderer rend;

    private Player player;

    void Start()
    {
        rend = GetComponent<Renderer>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (player.Live)
        {
            current += Time.deltaTime * xVelocity;
            rend.material.SetTextureOffset("_MainTex", new Vector2(current, 0));
        }
    }
}
