
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour {


    public Rigidbody rb;
    public Transform transf;
    public int SideForce = 5;
    public bool ischanged = false;
     void Start()
    {
      
    }

    void FixedUpdate () {

       
            
        rb.velocity = new Vector3(SideForce,0,0);
        float screen = Screen.width / Screen.dpi;
        float scrn = Mathf.Round(screen) +2;
        if (transf.position.x > scrn)
        {
            SideForce = -SideForce;
            rb.velocity = new Vector3(SideForce,0,0);
            transf.Rotate(0,180,0);
            ischanged = false;
           
        }
      if (!ischanged)
     {
            if (transf.position.x < -scrn)
            {
                ischanged = true;
                SideForce = -SideForce;
                transf.Rotate(0, 180, 0);
  }
        }

       
    }
}
