using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour {

    public GameObject ScoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        theScore += 1;
        ScoreText.GetComponent<Text>().text = "Weapons Collected: " + theScore + "/5";
        Destroy(gameObject);
    }
}