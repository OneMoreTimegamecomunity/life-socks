using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigglecontrol : MonoBehaviour
{
    [SerializeField] GameObject player; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        player.GetComponent<anakarakterharaket>().onGround = true;  
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player.GetComponent<anakarakterharaket>().onGround = false;

    }

}
