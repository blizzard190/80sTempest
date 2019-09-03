using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Pos;
    private Transform newPos;
    public Transform center;
    private void Update()
    {
        transform.LookAt(center);

        if (Input.GetKeyDown("left"))
        {
            GetPosL();
        }

        if (Input.GetKeyDown("right"))
        {
            GetPosR();
        }

        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

    }

    void GetPosL()
    {
        if (Pos == 16)
        {
            Pos = 0;
        }
        else
        {
            sides[Pos - 1] = newPos;
        }
    }

    void GetPosR()
    {
        if (Pos == 0)
        {
            Pos = 16;
        }
        else
        {
            sides[Pos + 1] = newPos;
        }
    }


}
