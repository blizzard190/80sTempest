using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Health
{
    private Restart restart;

    private void Start()
    {
        health = 10;
        restart = GameObject.Find("GameManager").GetComponent<Restart>();
    }

    private void Update()
    {
        if(health <= 0)
        {
            restart.Retry();
            restart.Activate();
        }
    }
}
