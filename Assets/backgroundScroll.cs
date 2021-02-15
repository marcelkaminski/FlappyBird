using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public float speed;
    public float loop_point;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < loop_point)
        {
            transform.position = StartPosition;
        }
    }


}
