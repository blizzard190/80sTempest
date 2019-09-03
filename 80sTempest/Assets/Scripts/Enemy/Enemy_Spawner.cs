using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{   
    private int cooldown = 60;


    public GameObject _enemy;


    void Update()
    {
        if (cooldown == 0)
        {
            Instantiate(_enemy, this.transform);
            cooldown = 60;
        }
        cooldown--;
    }
}
