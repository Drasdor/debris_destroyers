using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
public class OrbitMk2 : MonoBehaviour
{
    //This is the moving object
    public GameObject orbiter;
    //This is the thing the object moves around
    public GameObject planet;
    //Radius of orbit
    public double radius = 2.1;
    private float orbitAngle = 0;
    private float LocCounter;
    private float rotateCount = 0;
    private bool directionUp = false;
    private float x = 0.5f;
    private double planetX;
    private double planetY;

    // Start is called before the first frame update
    void Start()
    {
        planetX = GameObject.Find(planet.name).transform.position.x;
        planetY = GameObject.Find(planet.name).transform.position.y;
        LocCounter = Convert.ToSingle(radius);
        orbitAngle = Convert.ToSingle(UnityEngine.Random.Range(-60f,60f));
        LocCounter = Convert.ToSingle(UnityEngine.Random.Range(-2f, 2f));
    }

    // Update is called once per frame
    void Update()
    {
        if (globals.hits.Contains(orbiter.name) == false)
        {
            //rotate along x axis, move along y and z
            //circle equation = y2 + z2 = r2, radius is 0.2 r2 = 0.04
            float height = 0.015f;
            if (LocCounter >= 0 - radius && directionUp == false)
            { LocCounter -= Time.deltaTime; }
            else if (LocCounter <= radius && directionUp == true)
            { LocCounter += Time.deltaTime; }
            else
            {
                if (directionUp == false) { directionUp = true; }
                else { directionUp = false; }
            }
            float y = LocCounter;
            rotateCount += y;
            if (rotateCount >= 0.023)
            {
                GameObject.Find(orbiter.name).transform.Rotate(new Vector3(0f, 1f, 0f));
                rotateCount = 0;
            }
            float z = 0;
            if (directionUp == false)
            { z = Convert.ToSingle(Math.Sqrt((radius * radius) - (y - planetY) * (y - planetY)) + planetX); }
            else { z = 0 - Convert.ToSingle(Math.Sqrt((radius * radius) - (y - planetY) * (y - planetY)) + planetX); }
            if (directionUp == true)
            { x += (height * orbitAngle) / 180; }
            else
            { x -= (height * orbitAngle) / 180; }
            if (float.IsNaN(z))
            {
                GameObject.Find(orbiter.name).transform.position = new Vector3(y, x, 0);
            }
            else
            {
                GameObject.Find(orbiter.name).transform.position = new Vector3(y, x, z);
            }
            //Debug.Log($"y = {y} z = {z}");
        }
    }
}
