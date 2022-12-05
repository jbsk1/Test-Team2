using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickObj : MonoBehaviour
{
    [SerializeField]GameObject particle;
    TMP_Text text;

    void Awake()
    {
        text = particle.GetComponent<TMP_Text>();
    }

    public void OnClick()
    {
        var vars = Variables.instance;

        vars.oil += vars.oilperclick;
        SpawnParticle();
    }

    void SpawnParticle()
    {
        var vars = Variables.instance;

        text.text = vars.oilperclick.ToString(); //makes particle show you how much you earn
        //text.fontSize = Random.Range(1,1);
        StartCoroutine(_Particle());
    }

    IEnumerator _Particle()
    {
        GameObject particle = Instantiate(this.particle, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        //int direction = Random.Range(0,360);
        float speed = 1;
        int lifetime = 500;
        for(int i = 0; i < lifetime; i++)
        {
            particle.transform.position += new Vector3(0, speed*Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        Destroy(particle);
    }
}
