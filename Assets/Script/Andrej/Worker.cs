using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Worker: MonoBehaviour
{
    public Platform platform;
    public float speed;
    public int dir;

    

   
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + dir*speed*Time.deltaTime,transform.position.y);
        if (transform.position.x < platform.xmin && dir == -1) dir = 1 ;
        if (transform.position.x > platform.xmax && dir == 1) dir = -1;

    }
}
 