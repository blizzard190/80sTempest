using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public event Action Score;
  


    void Update()
    {
        this.transform.position += (this.transform.forward * 0.01f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Score();
            Destroy(collision.gameObject);
            Destroy(this);
        }
        if(collision.gameObject.tag == "center")
        {
            Destroy(this);
        }
    }
}
