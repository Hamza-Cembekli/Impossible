using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class die : MonoBehaviour
{
    public GameObject Player;
    public static die instance;
    public Behaviour Player_movement;
    public int position;
    public GameObject retry_btn;
    public GameObject barrier;
    public float targetX;
    public float targetY;
    public GameObject Jungle_decetor;


    public Animator anim;

    void Start()
    {
        instance = this;
      
    }

    public void Restart()
    {
        Vector3 newPosition = new Vector3(targetX, targetY, transform.position.z);
       Player.transform.position = newPosition;
        Jungle_decetor.SetActive(true);
        anim.SetTrigger("restart");
        retry_btn.SetActive(false);
        Player_movement.enabled = true;
        barrier.SetActive(false);
    
    }
    
        
    
    public void kill()
    {
        anim.SetTrigger("die");
        retry_btn.SetActive(true);
        Player_movement.enabled=false;
        barrier.SetActive(true);
       
    }
 
}
