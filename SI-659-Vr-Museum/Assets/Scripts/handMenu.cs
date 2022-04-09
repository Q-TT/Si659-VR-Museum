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
        mrp.transform.position = new Vector3(17.8f, 0f, 10.4f);
        mrp.transform.eulerAngles = new Vector3(0f, -60f, 0f);
    }

    public void moveToHall2()
    {
        mrp.transform.position = new Vector3(15.4f, 0f, 12f);
        mrp.transform.eulerAngles = new Vector3(0f, -122f, 0f);
    }

    public void moveToHall3()
    {
        mrp.transform.position = new Vector3(5.4f, 0f, -8.8f);
        mrp.transform.eulerAngles = new Vector3(0f, 90f, 0f);
    }

    public void moveToHall4()
    {
        mrp.transform.position = new Vector3(14f, 0f, 3.4f);
        mrp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}
