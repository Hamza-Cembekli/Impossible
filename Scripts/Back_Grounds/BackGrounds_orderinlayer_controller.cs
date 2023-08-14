using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGrounds_orderinlayer_controller : MonoBehaviour
{
    public int newOrderInLayer;// Hedef order in layer deðerini bu deðiþkene atadým

    public int newOrderInLayer2;
    public GameObject Cave_enter_dedector;
 
    public GameObject rock;
    public GameObject Snowy_tree;
    public GameObject Darknes;


    void Update()
    {
        if (Cave_enter_dedector.activeInHierarchy)
        {
            Darknes.SetActive(true);
            Snowy_tree.SetActive(false);
            rock.SetActive(false);
    
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = newOrderInLayer;
        }
        else {
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = newOrderInLayer2;
        }


    }
}
