using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boymovement : MonoBehaviour
{
    Rigidbody rigi;
    float jump_stronge = 5.0f;
    float run_speed = 2.0f;
    bool right, left;
    bool jump = false;
    public GameObject dust;
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        jump = false;

        if (dust.activeSelf == false)
        {
            dust.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        jump = true;

        if (dust.activeSelf == true)
        {
            dust.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.deltaPosition.x > 100.0f)
            {
                right = true;
                left = false;
            }
            if (finger.deltaPosition.x < -100.0f)
            {
                right = false;
                left = true;
            }
        }
        if (right == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(1.0f, transform.position.y, transform.position.z), run_speed * Time.deltaTime);
        }
        if (left == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-2.0f, transform.position.y, transform.position.z), run_speed * Time.deltaTime);
        }
        transform.Translate(0, 0, run_speed * Time.deltaTime);
    }
    public void jumpfonk()
    {
        if (jump == false)
        {
            rigi.velocity = Vector3.zero;
            rigi.velocity = Vector3.up * jump_stronge;
        }
    }
}
