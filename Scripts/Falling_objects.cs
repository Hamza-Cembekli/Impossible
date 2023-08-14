using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_objects : MonoBehaviour
{

    public GameObject dedector;
    public float fallDelay = 1f;
    public float DestroyDelay = 2f;
    

    
    public Animator anim;

    public Rigidbody2D rb;
   
    private void Update()
    {
        if (dedector.activeInHierarchy) { StartCoroutine(Fall()); }
    }


    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, DestroyDelay);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy( GetComponent<BoxCollider2D>());
            rb.simulated = false;
            anim.SetTrigger("broke");
            
        }

    }

   
}
