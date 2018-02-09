using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public int qula;
    public Text qulatxt;
    public int highScore;
    public int test;
    public int level;
    public AudioSource audio;
  void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");


        Debug.Log(highScore);
        Debug.Log(PlayerPrefs.GetInt("score"));
        qula = 0;

        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "gift")
        {    
            qula += 1;

            audio.Play();
             

            if(qula / 5 != (qula -1)/5)
            {
                Debug.Log("level up" + level);
                Movement movement = GameObject.Find("Player").GetComponent<Movement>();
                 if(movement.SideForce > 0) {
                    movement.SideForce += 1;
                }
                else
                {
                    movement.SideForce -= 1;

                }
            }

            if (qula / 10 != (qula - 1) / 10)
            {
                lifescore lifescore = GameObject.Find("Destroyerr").GetComponent<lifescore>();
                lifescore.life += 1;


            }
                 


                if (qula > PlayerPrefs.GetInt("highscore")) {
                PlayerPrefs.SetInt("highscore", qula);
            }
            PlayerPrefs.SetInt("score", qula);
        }
    }
    

    // Update is called once per frame
    void Update () {
                qulatxt.text = "score: " + qula.ToString();


    }
}
