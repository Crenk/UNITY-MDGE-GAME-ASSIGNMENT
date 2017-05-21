using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1ToLvl2 : MonoBehaviour {

    public int lvlNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Application.LoadLevel("Level" + " " + lvlNum);
        }
    }
}
