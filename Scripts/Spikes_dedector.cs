using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes_dedector : MonoBehaviour
{

    public Moving_Spikes move_spikes;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move_spikes.spikes_collider_control();
        }
    }
}
