using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        var doShoot = GetComponent<PlayerMovement>();
        doShoot.Shoot += Shoots;
    }

   

    private void Shoots()
    {
        Instantiate(bullet, this.transform.position, this.transform.rotation);
    }
}
