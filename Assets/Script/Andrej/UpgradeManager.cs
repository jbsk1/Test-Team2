using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int[] costs = { 10, 20, 30, 40 };
    public int[] rise = { 10, 20, 30, 40 };
    public Platform[] platforms;
    public Slave slave;
    public Whiper whiper;
    public Exchanger exchanger;


    

   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyVorker()
    {
        if (Variables.instance.money >= costs[0])
        {
            Variables.instance.money -= costs[0];
            Worker v = Instantiate(slave, platforms[0].transform.position, Quaternion.identity);
            platforms[0].workers.Add(v);
            v.platform = platforms[0];
            costs[0] += rise[0];  
            v.transform.parent = platforms[0].transform;


        }
    }

    public void BuyExchanger()
    {
        if (Variables.instance.money >= costs[1])
        {
            Variables.instance.money -= costs[1];
            Worker v = Instantiate(exchanger, platforms[2].transform.position, Quaternion.identity);
            platforms[2].workers.Add(v);
            v.platform = platforms[2];
            costs[1] += rise[1];
            v.transform.parent = platforms[2].transform;
        }
    }

    public void Exchange()
    {
        Variables.instance.money += Variables.instance.exchange * Variables.instance.oil;
    }

    public void BuyWhiper()
    {

        if (Variables.instance.money >= costs[2])
        {
            Variables.instance.money -= costs[2];
            Worker v = Instantiate(whiper, platforms[1].transform.position, Quaternion.identity);
            platforms[1].workers.Add(v);
            v.platform = platforms[1];
            costs[2] += rise[2];
            v.transform.parent = platforms[1].transform;
        }
    }

    public void BuyUpgrade()
    {
        if(Variables.instance.money >= costs[3])
        {
            Variables.instance.money -= costs[3];
            Variables.instance.oilperclick++;
            costs[3]+= rise[3];

        }
    }

}
