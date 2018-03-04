using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    // Update is called once per frame
    public Rigidbody rb;
    public int speed;
    Vector3 thisVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisVelocity = (-1.0F*rb.position.normalized)*speed;
        thisVelocity.y = 0;
    }
    void FixedUpdate()
    {
        rb.velocity = thisVelocity;
        rb.rotation = Quaternion.identity;

    }
    /*void Update()
    {
        transform.Translate(2 * Vector3.forward * Time.deltaTime);
    }*/
}
