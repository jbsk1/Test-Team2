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
        }
    }

    public void BuyWhiper()
    {

        if (Variables.instance.money >= costs[2])
        {
            Variables.instance.money -= costs[2];
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
