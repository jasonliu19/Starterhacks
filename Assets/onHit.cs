using UnityEngine;
using System.Collections;

public class onHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "weapon")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
}
