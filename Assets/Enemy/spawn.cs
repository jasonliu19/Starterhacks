using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    // we can spawn multiple enemies in the array
    public GameObject enemy;
    public float outradius;
    public float inradius;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    public float ypos;

    int randEnemy;

	// Use this for initialization
	void Start () {
        StartCoroutine(waitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
	}
  

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait); // how long before it starts spawning objects

        while (!stop)
        {
            float xpos = Random.Range(-outradius,outradius);
            float zpos = Random.Range(-outradius, outradius);

            // x, y, z: x is between neg to pos spawnvalues, y = 1, z is similar x
            Vector3 spawnPosition = new Vector3 (xpos,ypos,zpos);

            if(xpos*xpos+zpos*zpos<=outradius*outradius && xpos * xpos + zpos * zpos >= inradius *inradius)Instantiate(enemy, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.LookRotation(Vector3.zero));

            yield return new WaitForSeconds(spawnWait);
        }

    }
}
