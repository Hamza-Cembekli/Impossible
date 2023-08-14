using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter_Jungle : MonoBehaviour


{
    public GameObject Jungle_enter_dedected;
    public GameObject Cave_enter_dedector;
    public GameObject Winter_enter_dedector;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Cave_enter_dedector.SetActive(false);
            Winter_enter_dedector.SetActive(false);
            Jungle_enter_dedected.SetActive(true);

        }
    }
}
