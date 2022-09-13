using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class questionAppear : MonoBehaviour
{
    public Canvas questionCanvas;
    public Button submit;
    public InputField answer;
    public int score = 0;
    public GameObject questionText;

    void Start()
    {
        questionCanvas.GetComponent<Canvas> ().enabled = false;
        questionText.GetComponent<Text>().text = "WEAPONS COLLECTED:kskajka";

    }

    void OnTriggerEnter(Collider player){
        if(player.CompareTag("Player")){
            questionCanvas.GetComponent<Canvas> ().enabled = true;
            submit.onClick.AddListener(GetInputOnClickHandler);
        }
    }

    void GetInputOnClickHandler(){
        if(answer.text == "4"){
            score += 5;
            questionCanvas.GetComponent<Canvas> ().enabled = false;
            Debug.Log(score);
        }
    }
}
