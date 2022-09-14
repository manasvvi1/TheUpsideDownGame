using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loginRegister : MonoBehaviour
{
    public Button login, register;
    
    void Start()
    {
        login.onClick.AddListener(loginFunc);
        register.onClick.AddListener(registerFunc);   
    }

    void loginFunc(){
        Debug.Log("LOGIN");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void registerFunc(){
        Debug.Log("LOGIN");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
