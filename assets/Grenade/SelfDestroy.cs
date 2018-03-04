using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

    public int countdown;

    bool isDestroyed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        countdown--;
        if (countdown <= 0 && !isDestroyed)
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
	}
}
