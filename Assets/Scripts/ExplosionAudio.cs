using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudio : MonoBehaviour {

    public AudioClip grenadeAudio;
    public AudioSource grenadeSource;

	// Use this for initialization
	void Start () {
        grenadeSource.clip = grenadeAudio;
	}


}
