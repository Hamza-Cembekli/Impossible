using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_cave : MonoBehaviour
{


    public GameObject Winter_enter_dedector;
    public GameObject Jungle_enter_dedector;
    public GameObject cave_enter_dedected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cave_enter_dedected.SetActive(true);
            Jungle_enter_dedector.SetActive(false);
            Winter_enter_dedector.SetActive(false);
        }
    }
}
