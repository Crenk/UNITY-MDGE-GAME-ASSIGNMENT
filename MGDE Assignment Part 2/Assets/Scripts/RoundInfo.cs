using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("messageTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator messageTime()
    {
        GameObject.FindGameObjectWithTag("RoundInfo").SetActive(true);
        yield return new WaitForSeconds(4f);
        GameObject.FindGameObjectWithTag("RoundInfo").SetActive(false);
    }
}
