using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //This is the rigid body of the object
    public Rigidbody rb;
    //This is the moving object
    public GameObject craft;
    //This is the thing the object moves around
    public GameObject planet;
    public BoxCollider collide;
    public float speed = 0.1f;
    private Vector3 gravity = new Vector3(0,0,5);

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(gravity);
    }
    // Update is called once per frame
    void Update()
    {
        //calculate direction of gravity
        gravity = craft.transform.position - planet.transform.position;
        rb.AddForce(new Vector3(0,0,0) - gravity);
        if (Input.GetKey(KeyCode.W))
        {GameObject.Find(craft.name).transform.position += new Vector3(0f,speed,0f);}
        else if (Input.GetKey(KeyCode.A))
        { GameObject.Find(craft.name).transform.position += new Vector3(0-speed, 0f, 0f); }
        else if (Input.GetKey(KeyCode.D))
        { GameObject.Find(craft.name).transform.position += new Vector3(speed, 0f, 0f); }
        else if (Input.GetKey(KeyCode.S))
        { GameObject.Find(craft.name).transform.position += new Vector3(0f, 0-speed, 0f); }

        for (int i = 0; i < globals.hits.Count; i++)
        {
            GameObject.Find(globals.hits[i]).transform.position = new Vector3(3.65f + (Convert.ToSingle(i) *0.09f), 1.8f - (Convert.ToSingle(i-1) * 0.5f), -0.11f);
            GameObject.Find(globals.hits[i]).isStatic = true;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(globals.hits.Contains(col.collider.name) == false && col.collider.name != "Earth_model")
        {
            globals.hits.Add(col.collider.name);
        }
    }
}
