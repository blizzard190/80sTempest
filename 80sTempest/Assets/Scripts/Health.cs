using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    protected int health;

    protected void MinusHealth(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(this.gameObject, 0);
        }
    }
}
