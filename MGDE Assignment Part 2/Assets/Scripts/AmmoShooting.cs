using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class AmmoShooting : MonoBehaviour
{

    public float maxSpeed;
    public Transform fireTransform;
    public Rigidbody2D bullet;
    public float speed = 10.0f;
    public Rigidbody2D rb;

    int isRight = 1;

    float prevTime;
    public float cd;


    // Use this for initialization
    void Start()
    {
        prevTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }



    void shoot()
    {
        if (Time.time >= prevTime + cd) //ammo shoots for each interval(cooldown)
        {
            prevTime = Time.time;
            if (CnInputManager.GetAxis("Horizontal") > 0) //facing to the right
            {
                isRight = 1;
            }
            else if (CnInputManager.GetAxis("Horizontal") < 0) //facing to the left
            {
                isRight = -1;
            }

            if (CnInputManager.GetButton("Fire2")) //spawns the bullet
            {
                Rigidbody2D bulletInstance = Instantiate(bullet, fireTransform.position, Quaternion.Euler(Vector3.right)) as Rigidbody2D;
                bulletInstance.velocity = transform.right * isRight * maxSpeed;
                Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }
    }

}
