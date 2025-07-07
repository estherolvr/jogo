using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-12.68f, 1.48f, 5.61f); 
    }

    // Update is called once per frame
    void Update()
    {
      
         if((Input.GetAxis("Vertical") > 0) && (transform.position.y <= 4.4f))
        
        {
            transform.Translate(0, 0.01f, 0);
        }


        if ((Input.GetAxis("Vertical") < 0) && (transform.position.y <= -1.1f))

        {
            transform.Translate(0, -0.01f, 0);
        }
    }
}
