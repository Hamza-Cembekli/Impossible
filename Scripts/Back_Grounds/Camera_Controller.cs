using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    

    Player_movement Player;

    [SerializeField]

    Collider2D boundBox;

    Vector2 lastpos;

    [SerializeField]

    Transform backgrounds;

    [SerializeField]

    Transform background_cave;

    [SerializeField]

    Transform background_winter;

    void Start()
    {
        Player = Object.FindObjectOfType<Player_movement>();

        lastpos = transform.position;

    }

    
    void Update()
    {


        if (Player != null)
        {
            transform.position = new Vector3(
                Mathf.Clamp(Player.transform.position.x + 10, boundBox.bounds.min.x, boundBox.bounds.max.x),
               Mathf.Clamp(Player.transform.position.y, boundBox.bounds.min.y, boundBox.bounds.max.y),
                transform.position.z);
        }
        background_move();
    }

    void background_move()
    {

        Vector2 difrencebetween = new Vector2(transform.position.x - lastpos.x, transform.position.y - lastpos.y);
        backgrounds.position += new Vector3(difrencebetween.x, difrencebetween.y, 0f);
        lastpos = transform.position;

        Vector2 difrencebetween2 = new Vector2(transform.position.x - lastpos.x, transform.position.y - lastpos.y);
        background_cave.position += new Vector3(difrencebetween.x, difrencebetween.y, 0f);
        lastpos = transform.position;

        Vector2 difrencebetween3 = new Vector2(transform.position.x - lastpos.x, transform.position.y - lastpos.y);
        background_winter.position += new Vector3(difrencebetween.x, difrencebetween.y, 0f);
        lastpos = transform.position;
    }
}
