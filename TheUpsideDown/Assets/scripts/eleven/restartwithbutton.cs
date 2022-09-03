using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartwithbutton : MonoBehaviour
{
    [SerializeField]
    KeyCode restartgame;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(restartgame)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
