using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fetch : MonoBehaviour
{
    public GameObject camera;
    Vector3 initialPosition;
    public float time = 0.5f;
    int state = 0;
    float speed;
    Vector3 move_offset;
    Vector3 rotation;
    Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
        rotation = transform.eulerAngles;
        initialPosition = gameObject.transform.position;       
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 1)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, camera.transform.position - move_offset, speed * Time.deltaTime);
            if (Vector3.Distance(gameObject.transform.position, camera.transform.position - move_offset) <= 0.01f)
            {
                state = 3;
            }
        }
        if (state == 2)
        {
            state = 0;
            gameObject.transform.position = initialPosition;
            transform.eulerAngles = rotation;
            transform.localScale = scale;
        }
    }

    public void fetchObject()
    {
        if (state == 0)
        {
            speed = Vector3.Distance(initialPosition, camera.transform.position) / time;
            move_offset = 2 * Vector3.Normalize(camera.transform.position - initialPosition);
            state = 1;
        }
        if (state == 3)
        {
            state = 2;
        }
    }
}
