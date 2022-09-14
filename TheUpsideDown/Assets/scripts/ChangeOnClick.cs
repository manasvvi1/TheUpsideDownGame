using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeOnClick : MonoBehaviour
{
    public Button btn;

    void Start(){
        btn.onClick.AddListener(nextScene);
    }

    void nextScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
