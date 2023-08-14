using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
   

    Rigidbody2D rb;

    [SerializeField]
    Transform ground_check;

    [SerializeField]
    Animator anim;

    bool isgrounded;

    public LayerMask ground_mask;
  

    public float movespeed;
    public float jumpforce;

    private void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            Move();
            Jump();
            anim.SetFloat("move", Mathf.Abs(rb.velocity.x));
            anim.SetBool("isground", isgrounded);
        
    }


    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * movespeed, rb.velocity.y);

        if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }else if (rb.velocity.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Jump()
    {
      isgrounded =  Physics2D.OverlapCircle(ground_check.position, .2f, ground_mask);
        if(Input.GetButtonDown("Jump") && isgrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }

       
    }
}
