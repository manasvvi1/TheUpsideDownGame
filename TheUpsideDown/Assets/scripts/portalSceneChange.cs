using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalSceneChange : MonoBehaviour
{
    public int numQues;
    public int solvedQ;

    // Start is called before the first frame update
    void Start()
    {
        solvedQ = 0;
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    void OnTriggerEnter(Collider other){
        Debug.Log("QUIT!");
        if(other.CompareTag("portal") && solvedQ == numQues){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
