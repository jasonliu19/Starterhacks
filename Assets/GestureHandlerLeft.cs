using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandlerLeft : MonoBehaviour {

    // Use this for initialization
    public GameObject slotObject;
    public Rigidbody grenade;

	public void CreateGrenade()
    {
        Instantiate(grenade, slotObject.transform.position, Quaternion.identity);
    }
}
