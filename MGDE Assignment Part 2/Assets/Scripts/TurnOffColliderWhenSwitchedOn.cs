using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffColliderWhenSwitchedOn : MonoBehaviour {

    public GameObject invisWall;
    public UnlockDoor switchOffInvisWall;

	// Use this for initialization
	void Start () {
        switchOffInvisWall.GetComponent<UnlockDoor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Switch"))
        {
            Destroy(invisWall.gameObject);
        }
    }
}
