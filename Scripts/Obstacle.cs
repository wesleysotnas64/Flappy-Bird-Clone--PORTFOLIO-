using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private float velocity;
    private float yOffset;

    private Player player;

    void Awake()
    {
        velocity = 1;
        yOffset = Random.Range(-1.25f, 1.75f);
        transform.position = new Vector3(transform.position.x, yOffset, 0);
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        if(player.Live)
            transform.Translate(-(Time.deltaTime * velocity), 0, 0);

        if (transform.position.x <= -5)
        {
            yOffset = Random.Range(-1.25f, 1.75f);
            transform.position = new Vector3(2, yOffset, 0);
        }
    }
}
