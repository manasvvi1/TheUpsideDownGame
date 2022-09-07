using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputcontrols : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keypositive;

    [SerializeField]
    KeyCode keynegative;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keypositive)){
            GetComponent<Rigidbody>().velocity += v3Force;
        
        }

        if(Input.GetKey(keynegative)){
            GetComponent<Rigidbody>().velocity -= v3Force;
        
        }

    }
}
