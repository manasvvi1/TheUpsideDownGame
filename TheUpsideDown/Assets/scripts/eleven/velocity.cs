using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += v3Force;
    }
}
