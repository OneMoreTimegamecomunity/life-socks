using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nerdiventirmanma : MonoBehaviour
{
    [SerializeField] GameObject player;
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("girdi");
        player.GetComponent<anakarakterharaket>().nerdiventirmanma = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("cikti");
        player.GetComponent<anakarakterharaket>().nerdiventirmanma = false;

    }

}
