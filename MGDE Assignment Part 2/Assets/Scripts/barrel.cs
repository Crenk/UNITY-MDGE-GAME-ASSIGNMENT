using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrel : MonoBehaviour {
    public Transform Barrel;
    public GameObject explosionPrefab;
    public GameObject destructibleWall;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //barrel explosion
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(explosionPrefab, new Vector2(22.12f, -9.07f), Quaternion.EulerAngles(0,0,0)); //spawns the explosion particle effect when bullet hits the barrel
            Destroy(gameObject); //destory the barrel
            Destroy(destructibleWall); //destroy the destructible wall beside the barrel
        }
    }
}
