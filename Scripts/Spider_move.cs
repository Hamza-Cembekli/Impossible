using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider_move : MonoBehaviour
{

    public int startPosition; // Baþlangýç pozisyonu
    public float speed;   // Hareket hýzý
    public Transform[] points;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startPosition].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
