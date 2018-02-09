using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour {
    public Transform trans;
	
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, trans.transform.position, 1);
    }
}
