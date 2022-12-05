using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public static Variables instance;
    public int money = 0;
    public int oil = 0;
    public int oilperclick = 1;

    void Awake()
    {
        instance = this;
    }
}
