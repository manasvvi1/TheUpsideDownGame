using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionAppear : MonoBehaviour
{
    public void Canvas questionCanvas;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }

    void OnTriggerEnter(Collider player){
        if(player.CompareTag("player")){
            questionAppear.GetComponent<Canvas> ().enabled = true;
        }
    }
}
