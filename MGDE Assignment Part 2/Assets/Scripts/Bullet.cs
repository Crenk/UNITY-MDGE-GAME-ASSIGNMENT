using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float maxLife = 0.5f;

    // Use this for initialization
    void Start () {
        Destroy(this.gameObject, maxLife);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject); //destroy the bullet when it collides with anything but the player

        }
    }

}
