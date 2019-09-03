using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    [Header("PointOfInterests")]
    public List<GameObject> pointsOfInterest = new List<GameObject>();
    public int maxPOI;

    [Header("POIAmount")]
    [SerializeField]
    private int _POIAmount;

    void Start()
    {

        for (int i = 0; i < _POIAmount; i++)
        {
            var poi = GameObject.Find("Poi" + i);
            pointsOfInterest.Add(poi);
        }
            
            maxPOI = pointsOfInterest.Count;
            int randomPOI = Random.Range(0, maxPOI);
            this.transform.LookAt(pointsOfInterest[randomPOI].transform);
    }

    void LateUpdate()
    {
        this.transform.position += (this.transform.forward*0.005f);
    }
}
