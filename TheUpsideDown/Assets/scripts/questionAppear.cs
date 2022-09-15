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
    public static int score = 0, lives = 5;
    public GameObject questionText;
    public GameObject scoreText, livesText, portal;
    public int numQ, solvedQ;
    public string[] questions = {"4+4=?","5+2=?","5+5=?","What is the name of the game?","4+2=?","1+1=?","5+2=?","5+5=?","1+2=?"};
    public string[] answers = {"8","7","10","The Upside Down","6","2","7","10","3"};
    public int index = 0;

    void Start()
    {
        questionCanvas.GetComponent<Canvas> ().enabled = false;
        solvedQ = 0;
        portal.SetActive(false);
    }

    void OnTriggerEnter(Collider player){
        if(player.CompareTag("Player")){
            questionCanvas.GetComponent<Canvas> ().enabled = true;
            submit.onClick.AddListener(GetInputOnClickHandler);
        }
    }

    void GetInputOnClickHandler(){
        if(answer.text == "4"){
            questionCanvas.GetComponent<Canvas> ().enabled = false;
            solvedQ += 1;
            score += 5;
            index++;
            scoreText.GetComponent<Text>().text = "SCORE: " + score;
            Debug.Log(score);

            if(solvedQ == numQ){
                portal.SetActive(true);
            }
        }
        else{
            lives--;
            if(lives <= 0){
                SceneManager.LoadScene(8);
            }
            else{
                livesText.GetComponent<Text>().text = "LIVES: " + lives;
            }
        }
    }
}