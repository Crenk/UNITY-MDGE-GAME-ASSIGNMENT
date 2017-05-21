using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class CharacterController : MonoBehaviour
{

    public float speed = 10.0f;
    public Rigidbody2D rb;
    public Animator animControl;
    public float jump = 10.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move();
        attack();
    }

    void move()
    {
        if (CnInputManager.GetAxis("Horizontal") != 0)//move left and right
        {
            if (CnInputManager.GetAxis("Horizontal") > 0)
            {
                rb.velocity += Vector2.right * speed * Time.deltaTime;
                transform.localScale = new Vector3(0.35f, 0.35f);
                animControl.SetBool("run", true);
            }
            else if (CnInputManager.GetAxis("Horizontal") < 0)
            {
                rb.velocity += Vector2.left * speed * Time.deltaTime;
                transform.localScale = new Vector3(-0.35f, 0.35f);
                animControl.SetBool("run", true);
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
        }

        if (rb.velocity == Vector2.zero)
        {

            animControl.SetBool("run", false);
        }

        if (CnInputManager.GetButtonDown("Jump"))
        {
            if (!animControl.GetBool("jump"))
            {
                rb.AddForce(new Vector2(0, 9), ForceMode2D.Impulse);
            }
            animControl.SetBool("jump", true);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "PreventCollider")
        {
            if (animControl.GetBool("jump") == true)
            {
                animControl.SetBool("melee", false);
            }
            animControl.SetBool("jump", false);
        }
        else
        {
            animControl.SetBool("jump", true);
        }
    }

    void attack()
    {
        if (CnInputManager.GetButtonDown("Fire1"))
        {
            animControl.SetBool("melee", true);
        }
        else
        {
            animControl.SetBool("melee", false);
        }

        if (CnInputManager.GetButton("Fire2"))
        {
            animControl.SetBool("shoot", true);
        }
        else
        {
            animControl.SetBool("shoot", false);
        }
    }
}
