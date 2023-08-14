using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winter_Back_ground : MonoBehaviour
{
    public int newOrderInLayer;// Hedef order in layer deðerini bu deðiþkene atadým

    public int newOrderInLayer2;
    
    public GameObject Winter_enter_dedector;

    public GameObject rock;
    public GameObject Snowy_tree;
    public GameObject Darknes;

    void Update()
    {
        if (Winter_enter_dedector.activeInHierarchy)
        {
            Darknes.SetActive(false);
            Snowy_tree.SetActive(true);
     
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
