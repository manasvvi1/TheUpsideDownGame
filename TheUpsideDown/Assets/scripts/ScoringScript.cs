using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour {

    public GameObject weaponText;
    public static int Weapons;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        collectSound.Play();
        Weapons = Weapons + 1;
        weaponText.GetComponent<Text>().text = "WEAPONS COLLECTED: " + Weapons + "/5";
        Destroy(gameObject);
    }
}