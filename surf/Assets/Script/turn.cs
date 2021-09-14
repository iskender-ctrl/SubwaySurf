using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    string nm;
    float speed = 500.0f;
    void Start()
    {
        nm = gameObject.tag;
    }

    void Update()
    {
        if (nm == "gold")
        {
            transform.Rotate(0, speed * Time.deltaTime, 0, Space.World);
        }
    }
}
