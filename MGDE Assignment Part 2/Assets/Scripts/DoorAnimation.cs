using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour {

    public Animator animControl;
    public UnlockDoor unlockDoorAnim;

	// Use this for initialization
	void Start () {
        unlockDoorAnim.GetComponent<UnlockDoor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Switch"))
        {
            animControl.SetBool("unlock", true);
        }
    }
}
