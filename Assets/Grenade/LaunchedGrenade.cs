using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchedGrenade : MonoBehaviour {

    // Use this for initialization
    public float delay = 1f;

    public float radius = 3f;

    public float force = 700f;

    public float speed = 5f;

    float countdown;

    bool hasExploded = false;

    bool isThrown = false;

    public GameObject explosionEffect;

    // Use this for initialization
    void Start()
    {
        countdown = delay;

    }

    // Update is called once per frame
    void Update()
    {
        if (isThrown)
        {
            countdown -= Time.deltaTime;
        }
        if ((countdown <= 0f) && (hasExploded == false))
        {
            Explode();
            hasExploded = true;
        }

    }

    public void Shoot(Vector3 vel)
    {
        isThrown = true;
        this.GetComponent<Rigidbody>().velocity = vel;
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
}
