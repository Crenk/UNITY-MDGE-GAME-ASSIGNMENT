using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour {

    public Animator animControl;
    public GameObject[] hearts;
    private int lives;
    public KillZone killZone;
    public GameObject text;
    public Spawn spawnPoint;

    // Use this for initialization
    void Start () {
        lives = hearts.Length;
        killZone.GetComponent<KillZone>();
        text.GetComponent<GameObject>();
        Time.timeScale = 1;
        spawnPoint.GetComponent<Spawn>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Restart")
        {
            lives--;
            hearts[lives].SetActive(false);
            //transform.position = new Vector3(-19.53f, -0.38f, 0f);
            if (transform.position == spawnPoint.transform.position)
            {

                animControl.SetBool("death", false);
            }
        }

        if (lives == 0)
        {
            text.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
