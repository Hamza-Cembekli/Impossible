using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    public int startPosition; // Ba�lang�� pozisyonu
    public float speed;   // Hareket h�z�
    public Transform[] points;

    private int i;
    private void Start()
    {
        // Platformu ba�lang�� pozisyonuna ta��
        transform.position = points[startPosition].position;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position)< 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

   
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
