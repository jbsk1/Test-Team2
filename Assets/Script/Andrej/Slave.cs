using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slave :Worker
{
    public float generateRate;

    private void Start()
    {
        StartCoroutine(Cicle()); 
    }


    IEnumerator Cicle()
    {
        yield return new WaitForSeconds(generateRate/Variables.instance.boostWorkers);
        Variables.instance.oil++;
        yield return  StartCoroutine(Cicle());
    }

}
