using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jungle_Back_Ground : MonoBehaviour
{
    public int newOrderInLayer;// Hedef order in layer de�erini bu de�i�kene atad�m

    public int newOrderInLayer2;
   
    public GameObject Jungle_enter_dedector;
    public GameObject rock;
    public GameObject Snowy_tree;
    public GameObject Darknes;

  
    void Update()
    {
        if (Jungle_enter_dedector.activeInHierarchy)
        {
            rock.SetActive(true);
        
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = newOrderInLayer;
        }
        else
        {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = newOrderInLayer2;
        }
    }
}
