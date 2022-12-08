using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiper : Worker
{
    public float boost;
    private void Start()
    {
        Variables.instance.boostWorkers += boost;
    }



}
