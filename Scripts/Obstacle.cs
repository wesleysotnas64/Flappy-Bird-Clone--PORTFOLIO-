using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private float velocity;

    private Player player;

    void Awake()
    {
        velocity = 1;
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        if(player.Live)
            transform.Translate(-(Time.deltaTime * velocity), 0, 0);

        if (transform.position.x < -3) Destroy(this.gameObject);
    }
}
