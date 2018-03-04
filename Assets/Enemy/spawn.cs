using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

    // we can spawn multiple enemies in the array
    public GameObject enemy;
    public Vector3 spawnValues;
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
            float xpos = Random.Range(-spawnValues.x, spawnValues.x);
            float ypos = Random.Range(-spawnValues.y, spawnValues.y);

            // x, y, z: x is between neg to pos spawnvalues, y = 1, z is similar x
            Vector3 spawnPosition = new Vector3 (xpos,1,ypos);

            Instantiate(enemy, spawnPosition + transform.TransformPoint(0, 0, 0), Quaternion.LookRotation(Vector3.zero));

            yield return new WaitForSeconds(spawnWait);
        }

    }
}
