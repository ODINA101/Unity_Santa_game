using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WonLost : MonoBehaviour {

    public Dispawner disp;
    public Transform sparkle;
    public ParticleSystem parter;
    public GameObject partic;
    public Transform giftpos;
    public bool starter = true;
  

    

    void OnCollisionEnter(Collision collisioninfo)
    {

        if (collisioninfo.collider.name == "Destroyerr")
        {
           
             
            Instantiate(partic,giftpos.position, giftpos.rotation);
            parter.Play(starter);



            

            
        }


        if (collisioninfo.collider.name == "sakvamuri")
        {
            disp.Destroyer();
        }

    }
    

}
