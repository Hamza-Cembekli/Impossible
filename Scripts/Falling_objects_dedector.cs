using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_objects_dedector : MonoBehaviour
{
    public GameObject fall_dedector;
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fall_dedector.SetActive(true);
        }
    }
}
