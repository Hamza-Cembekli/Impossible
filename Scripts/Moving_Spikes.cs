using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Spikes : MonoBehaviour
{
    public Transform player;
    private BoxCollider2D boxCollider2D;
    public bool follow;
    public float targetX;
    public float targetY;

    private void Start()
    {
        targetX = 835.9169f;
        targetY = 3.63f;
        follow = false;
        boxCollider2D = GetComponent<BoxCollider2D>();

        
        boxCollider2D.enabled = false;
    }


    public void spikes_collider_control()
    {
        
         boxCollider2D.enabled = true;
        follow = true;
    }


    public void Player_dead()
    {
        follow = false;
        boxCollider2D.enabled = false;
    }

    private void Update()
    {

        if (follow == true)
        {
            Vector3 objPosition = transform.position; 
            Vector3 playerPosition = player.position; 

            objPosition.x = playerPosition.x; 
            transform.position = objPosition;
        }
        else
        {
            Vector3 newPosition = new Vector3(targetX, targetY, transform.position.z);
            transform.position = newPosition;
        }
    }

}
