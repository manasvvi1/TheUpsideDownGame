using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalSceneChange : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        // Debug.Log("QUIT!");
        if(other.CompareTag("portal")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
