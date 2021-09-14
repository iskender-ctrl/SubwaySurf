using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    Transform boy_position;
    Vector3 distance;
    float speed = 4.0f;
    void Start()
    {
        boy_position = GameObject.Find("Boy").transform;
    }


    void LateUpdate()
    {
        distance = new Vector3(boy_position.position.x, transform.position.y, boy_position.position.z - 2.17f);

        transform.position = Vector3.Lerp(transform.position, distance, Time.deltaTime);

    }
}
