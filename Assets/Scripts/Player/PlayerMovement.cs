using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instance;

    public TextMeshPro debug;

    Rigidbody2D rb;
    public float moveSpeed = 7f;
    public float jumpForce = 1;

    private BoxCollider2D coll;
    private Animator anim;

    [SerializeField] private LayerMask jumpableGround;

    [HideInInspector]
    public bool facingRight;

    [HideInInspector]
    public float dirX = 0;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (dirX != 0) anim.SetBool("walking", true);
        else anim.SetBool("walking", false);

        transform.rotation = Quaternion.identity;
        //Movement
        transform.position = new Vector3(transform.position.x + (dirX * moveSpeed), transform.position.y, transform.parent.transform.position.z);
        //rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //Flip the sprite if facing left
        if (dirX < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            facingRight = false;
        }
        else if (dirX > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            facingRight = true;
        }


        //transform.position = new Vector3(transform.position.x, transform.position.y, GetComponentInParent<Transform>().position.z);

    }

    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0, jumpForce));

        anim.SetBool("jump", true);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("jump", false);
    }
}
