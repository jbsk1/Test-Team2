using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float offset;
    public float xmin;
    public float xmax;
    public float y;  
    public List<Worker> workers ;
    
    // Start is called before the first frame update 
    void Start()
    {
        xmax = transform.position.x + offset ;
        xmin = transform.position.x - offset ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
;