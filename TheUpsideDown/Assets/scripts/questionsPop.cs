using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionsPop : MonoBehaviour
{
    // public Button btnClick;
    // public InputField answer;
    // public GameObject human;
    // public AudioSource killSound;
    // public AudioSource incorrectsound;
    // public GameObject canvas;
    // // public delegate void ScoreUpdate(int value);
    // // public static event ScoreUpdate OnUpdate;
    // public static int countQues=0;
    // public GameObject incorrectCanvas;
    // //public Button tryAgain;

    // //public Text tryAgainText;
    // bool negative = true;

    // // Start is called before the first frame update
    // void Start(){
    //     btnClick.onClick.AddListener(GetInputOnClickHandler);
    // }

    // public void GetInputOnClickHandler(){
    //     Debug.Log("Input : " + answer.text);
    //     if(answer.text == "23"){
    //         //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
    //         Destroy(btnClick);
    //         killSound.Play();
    //         Debug.Log("correct answer");
    //         GoldPickup.score += 40;
    //         //OnUpdate(GoldPickup.score);
    //         StartCoroutine(DisableCanvas(canvas));
    //         Destroy(human);
    //         popupappear.movespeed = 3;
    //         countQues++;
    //         SuccessOver(countQues, GoldPickup.goldCoinNo);
    //     }
    //     else{
    //         if(!Input.GetKey(KeyCode.Space))
    //         {
    //             GoldPickup.score -= 5;
    //             incorrectsound.Play();
    //         }
    //         answer.text = "";
           
    //         Debug.Log("Negative");
    //         canvas.GetComponent<Canvas>().enabled = false;
    //        /* incorrectCanvas.GetComponent<Canvas> ().enabled = true;
    //         CallEnumerator();
    //        */ //OnUpdate(GoldPickup.score);
    //     }
    // }

    // void CallEnumerator()
    // {
    //     StartCoroutine(GetDisableOnClick(incorrectCanvas));
    // }
    // public void SuccessOver(int count, int coins)
    // {
    //     if ((count >= 15) && (coins >= 54))
    //     {
    //         //OnUpdate(GoldPickup.score);
    //         StartCoroutine(ChangeScreens());

    //     }
    // }
    // IEnumerator ChangeScreens()
    // {
    //     yield return new WaitForSeconds(0.5f);
    //     //OnUpdate(GoldPickup.score);
    //     SceneManager.LoadScene(5);
    // }

    // IEnumerator GetDisableOnClick(GameObject c){
    //     yield return new WaitForSeconds(0.75f);
    //     c.GetComponent<Canvas> ().enabled = false;
    //     popupappear.movespeed = 3;
    //     //canvas.GetComponent<Canvas> ().enabled = true;
    //     //canvas.GetComponent<Canvas> ().enabled = true;
    //     //StartCoroutine(DisableCanvas(incorrectCanvas));
    // }
    // // IEnumerator DisableText(Text c){
    // //     yield return new WaitForSeconds(2);
    // //     c.enabled=false;
    // // }
    // IEnumerator DisableCanvas( GameObject c)
    // {
    //     yield return new WaitForSeconds(1);
    //     //OnUpdate(GoldPickup.score);
    //     c.SetActive(false);
    // }
}
