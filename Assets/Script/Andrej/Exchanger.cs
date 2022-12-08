using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exchanger : Worker
{
   
    public int maxExchange;
    // Start is called before the first frame update
    void Start()
    {
        Variables.instance.exchangeBoost +=  maxExchange;
    }

    

  
}
