using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EarthRotation : MonoBehaviour
{
    public Transform earthModel;
    private double counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting...");
    }
    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if(counter > 0.1)
        { earthModel.Rotate(new Vector3(0f, 0.1f, 0f));
            counter = 0;
        }
    }
}
