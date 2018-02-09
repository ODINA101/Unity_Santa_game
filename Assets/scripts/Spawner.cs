using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform spawnPos;
    public GameObject spanee;
  
	void Update () {

        if (Input.GetMouseButtonDown(0)){
            Instantiate(spanee, spawnPos.position,spawnPos.rotation);

           
        }
       


    }
}
