using UnityEngine;
using System;

public class Orbit : MonoBehaviour
{
    //This is the rigid body of the object
    public Rigidbody rb;
    //This is the moving object
    public GameObject orbiter;
    //This is the thing the object moves around
    public GameObject planet;
    //This changes the speed that the object moves at
    public int speed = 10;

    void Start()
    {
        rb.useGravity = false;
        rb.AddForce(initialiseVel(planet, orbiter, speed));
    }

    void Update()
    {
        Vector3 force = new_force(planet, orbiter, speed);
        //Debug.Log($"x {force.x} y {force.y} z {force.z}");
        rb.AddForce(force.x * Time.deltaTime, force.y * Time.deltaTime, force.z * Time.deltaTime);
    }

    private static Vector3 initialiseVel(GameObject planet, GameObject orbiter, int speed)
    {
        System.Random ran = new System.Random();
        Vector3 force;
        int dir = ran.Next(1, 4);
        float xdif = GameObject.Find(planet.name).transform.position.x - GameObject.Find(orbiter.name).transform.position.x;
        float ydif = GameObject.Find(planet.name).transform.position.y - GameObject.Find(orbiter.name).transform.position.y;
        float zdif = GameObject.Find(planet.name).transform.position.z - GameObject.Find(orbiter.name).transform.position.z;
        force.x = xdif * speed * 10;
        force.y = ydif * speed * 10;
        force.z = zdif * speed * 10;

        if (Math.Abs(xdif) >= Math.Abs(ydif) && Math.Abs(xdif) >= Math.Abs(zdif))
        {
            force.x = 0;
        }
        else if (Math.Abs(ydif) >= Math.Abs(xdif) && Math.Abs(ydif) >= Math.Abs(zdif))
        {
            force.y = 0;
        }
        else
        {
            force.z = 0;
        }
        return force;
    }

    private static Vector3 new_force(GameObject planet, GameObject orbiter, int speed)
    {
        Vector3 force;
        float xdif = GameObject.Find(planet.name).transform.position.x - GameObject.Find(orbiter.name).transform.position.x;
        force.x = xdif * speed;
        float ydif = GameObject.Find(planet.name).transform.position.y - GameObject.Find(orbiter.name).transform.position.y;
        force.y = ydif * speed;
        float zdif = GameObject.Find(planet.name).transform.position.z - GameObject.Find(orbiter.name).transform.position.z;
        force.z = zdif * speed;
        return force;
    }
}
