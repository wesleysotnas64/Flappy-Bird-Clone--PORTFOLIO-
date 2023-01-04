using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private string namePlayer;
    void Awake()
    {
        player = GameObject.Find(namePlayer).GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space")) player.Jump();
    }
}
