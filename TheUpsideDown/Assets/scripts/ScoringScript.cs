using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour {

    public GameObject ScoreText;
    public int Weapons;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        Weapons += 1;
        ScoreText.GetComponent<Text>().text = "WEAPONS COLLECTED: " + Weapons + "/5";
        Destroy(gameObject);
    }
}