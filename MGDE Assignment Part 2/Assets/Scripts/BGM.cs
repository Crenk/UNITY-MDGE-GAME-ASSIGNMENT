using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(audioSource); //allows the BGM to continue to play transitioning from Lvl1 to Lvl2
    }
	
	// Update is called once per frame
	void Update () {

    }
}
