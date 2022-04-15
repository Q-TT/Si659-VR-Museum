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
        mrp.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        mrp.transform.position = new Vector3(-9f, 1.75f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moveToHall1()
    {
        mrp.transform.position = new Vector3(-9f, 1.75f, 3f);
        mrp.transform.eulerAngles = new Vector3(0f, 90f, 0f);

    }

    public void moveToHall2()
    {
        mrp.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        mrp.transform.position = new Vector3(-6.7f, 1.75f, -16.2f);
    }

    public void moveToHall3()
    {
        mrp.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        mrp.transform.position = new Vector3(27f, 1.75f, -16f);
    }

    public void moveToHall4()
    {
        mrp.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        mrp.transform.position = new Vector3(34f, 1.75f, -4f);
    }
}
