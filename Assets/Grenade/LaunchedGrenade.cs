﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchedGrenade : MonoBehaviour {

    // Use this for initialization
    public float delay = 1f;

    public float radius = 3f;

    public float force = 700f;

    public float speed = 5000000000f;

    float countdown;

    public int colliderEnableCountdown = 40;

    bool hasExploded = false;

    bool isThrown = false;

    Vector3 thisVelocity = Vector3.zero;

    public GameObject explosionEffect;

    // Use this for initialization
    void Start()
    {
        countdown = delay;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isThrown)
        {
            colliderEnableCountdown--;
            countdown -= Time.deltaTime;
            this.GetComponent<Rigidbody>().velocity = thisVelocity;
        }
        if ((countdown <= 0f) && (hasExploded == false))
        {
            Explode();
            hasExploded = true;
        }

        if (colliderEnableCountdown < 0)
        {
            this.GetComponent<SphereCollider>().enabled = true;
        }

    }

    public void Shoot(Vector3 vel)
    {
        isThrown = true;
        //this.GetComponent<Rigidbody>().velocity = vel*speed;
        thisVelocity = vel * speed;
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            GameObject go = nearbyObject.gameObject;
            if (go != null && go.tag == "enemy")
            {
                Destroy(go);
            }

        }

        Destroy(gameObject);
    }
    
    void OnCollisionEnter(Collision c)
    {
        Explode();
    }
}
