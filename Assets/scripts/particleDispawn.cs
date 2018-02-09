using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleDispawn : MonoBehaviour {

    public float ParticleLife = 2f;

	
	
	void Update () {
        if (ParticleLife > 0)
        {
            ParticleLife -= Time.deltaTime;
            if (ParticleLife <= 0)
            {

                Destroyy();
            }


        }
        

	}

    public  void Destroyy()
    {
        Destroy(this.gameObject);

    }


}
