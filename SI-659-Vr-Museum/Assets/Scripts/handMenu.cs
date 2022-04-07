using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

public class handMenu : MonoBehaviour
{
    public GameObject mrp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveToHall1()
    {
        mrp.transform.position = new Vector3(0f, 0f, 0f);
    }

    public void moveToHall2()
    {
        mrp.transform.position = new Vector3(10f, 0f, 2f);
    }

    public void moveToHall3()
    {
        mrp.transform.position = new Vector3(20f, 0f, -7f);
    }
}
