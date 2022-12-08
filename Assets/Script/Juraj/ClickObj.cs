using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickObj : MonoBehaviour
{
    [SerializeField]GameObject particle;
    TMP_Text pText;
    float pSpeed = 1;
    int pFrameTime = 500;

    void Awake()
    {
        pText = particle.GetComponent<TMP_Text>();
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
        pText.text = vars.oilperclick.ToString(); //makes particle show you how much you earn
        
        StartCoroutine(_Particle());
    }

    IEnumerator _Particle()
    {
        GameObject particle = Instantiate(this.particle, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        TMP_Text pText = particle.GetComponent<TMP_Text>();
        
        for(int i = 0; i < pFrameTime; i++)
        {
            particle.transform.position += new Vector3(0, pSpeed*Time.deltaTime, 0);
            pText.color -= new Color(0,0,0, 1f/pFrameTime);
            //Debug.Log(pText.color.a);
            yield return new WaitForEndOfFrame();
        }
        Destroy(particle);
    }
}
