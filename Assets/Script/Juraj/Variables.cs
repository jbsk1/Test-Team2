using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    static Variables instance;
    public int money = 0;
    public int oil = 0;
    public int oilperclick = 1;

    private void Awake()
    {
        instance = this;
    }
}
