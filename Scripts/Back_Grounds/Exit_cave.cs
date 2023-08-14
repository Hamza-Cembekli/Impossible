using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_cave : MonoBehaviour
{

    public GameObject Cave_enter_dedector; 
    public GameObject Jungle_enter_dedector;
    public GameObject Winter_enter_dedecteor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Winter_enter_dedecteor.SetActive(true);
            Jungle_enter_dedector.SetActive(false);
            Cave_enter_dedector.SetActive(false);
        }
    }
}
