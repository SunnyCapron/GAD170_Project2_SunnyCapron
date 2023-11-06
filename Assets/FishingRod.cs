using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingRod : MonoBehaviour
{
    public Transform myTransform;
    public Vector3 axis;
    public float turnspeed;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space));
        {
            myTransform.Rotate(axis, turnspeed);
            Debug.Log(myTransform.rotation.eulerAngles.x);
        }

       
       
       
            
    }

        
}

