using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour {

    public int endRadius;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	/* Update () {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("enemy");
        float[] dist = new float[gos.Length];
        float min = 10000;
        for(int i = 0; i < gos.Length; i++)
        {
            dist[i] = (gos[i].transform.position).sqrMagnitude;
            if (dist[i] < min) min = dist[i];
        }
        if (min < endRadius)
        {
            SceneManager.LoadScene("test_menu_scene");
            //call the end game function here
        }
	}*/

    void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;
        if(go.tag == "enemy")
        {
            GameObject[] gos = GameObject.FindGameObjectsWithTag("enemy");
            foreach(GameObject g in gos)
            {
                Destroy(g);
            }
            SceneManager.LoadScene("test_menu_scene");
        }
    }
}
