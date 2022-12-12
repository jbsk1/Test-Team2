using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Variables : MonoBehaviour
{
    public static Variables instance;
    public int money = 0;
    public int oil = 0;
    public int oilperclick = 1;
    public float boostWorkers = 1;
    public int exchange;
    public int exchangeBoost;
    public TMP_Text oiltxt;
    public TMP_Text moneytxt;
    public TMP_Text exchangetxt;
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        StartCoroutine(ChangeExchange());

    }

    IEnumerator ChangeExchange()
    {
    while(true)
    {
        yield return new WaitForSeconds(5);
        exchange = Random.Range(0, exchangeBoost + 5);
    }
    }

    public void Update()
    {
        oiltxt.text = oil.ToString();
        moneytxt.text = money.ToString();
        exchangetxt.text = exchange.ToString();

    }
}
