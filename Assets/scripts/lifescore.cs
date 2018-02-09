using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lifescore : MonoBehaviour {
    public int life = 3;
    public Text lifeText;

	// Use this for initialization
	void Start () {
        lifeText.text = life.ToString();
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "gift")
        {

            life -= 1;
        }
        
    }

    // Update is called once per frame
    void Update () {
        if(life <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        lifeText.text = life.ToString();
    }
}
