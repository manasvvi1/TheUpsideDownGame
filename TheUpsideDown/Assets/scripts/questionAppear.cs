using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionAppear : MonoBehaviour
{
    public Canvas questionCanvas;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider player){
        if(player.CompareTag("Player")){
            questionCanvas.GetComponent<Canvas> ().enabled = true;
        }
    }
}
