using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public SideManager SideManeger;
    public int Pos;
    private Vector3 VecPos;
    private Transform newPos;
    public Transform center;
    public event Action Shoot;

    private void Start()
    {
        SideManager sideManeger = GameObject.Find("SideManager").GetComponent<SideManager>();
    }

    private void Update()
    {
        transform.LookAt(center);
        Vector3 VecPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        transform.position = VecPos;

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

    

    void GetPosL()
    {
        if (Pos == 16)
        {
            Pos = 0;
            SideManeger.sides[0].GetComponent<Side>().spawn = newPos;
            
        }
        else
        {
            SideManeger.sides[Pos - 1].GetComponent<Side>().spawn = newPos;
            Pos -= 1;
        }
    }

    void GetPosR()
    {
        if (Pos == 0)
        {
            Pos = 16;
            SideManeger.sides[16].GetComponent<Side>().spawn = newPos;
        }
        else
        {
            SideManeger.sides[Pos + 1].GetComponent<Side>().spawn = newPos;
            Pos += 1;
        }
    }


}
