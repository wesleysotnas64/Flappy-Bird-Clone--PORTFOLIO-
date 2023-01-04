using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float spawTime;
    private float currentTime;

    private Player player;
    public GameObject pipePrefab;
    private float offsetY;
    void Awake()
    {
        currentTime = 0;
        spawTime = 2.0f;

        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= spawTime && player.Live)
        {
            currentTime = 0;

            offsetY = Random.Range(-1.25f, 1.75f);
            Instantiate
            (
                pipePrefab,
                new Vector3(transform.position.x, offsetY, 0),
                transform.rotation
            );
        }
    }
}
