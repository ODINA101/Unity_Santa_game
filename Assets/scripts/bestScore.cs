using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class bestScore : MonoBehaviour {

    // Use this for initialization
    public Text bestSc;
      int sc;
    public string mytext = "BestScore: ";


    private void Start()
    {

        sc = PlayerPrefs.GetInt("highscore");
       string korkota = mytext + sc.ToString();
        bestSc.text = korkota;

        Debug.Log("best score for main screne: " + sc);
       
         
    }
    private void Update()
    {

    }

}
