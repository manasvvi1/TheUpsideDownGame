using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoPop : MonoBehaviour
{
    public GameObject uiObject;
    void Start() //Make the text invisible at first
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player) // Once the player enters the trigger, the text will display
    {
        if(player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec() // Destroy the text and trigger after five seconds
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}

