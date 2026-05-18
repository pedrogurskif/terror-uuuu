using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LightsOut : MonoBehaviour
{
    private Light light;
    private float timer = 0f;
    private float timerDie = 0f;
    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        timerDie += Time.fixedDeltaTime;
        if(timerDie < 10)
        {
            Blink();
        }
        else
        {
            light.intensity = 0;
        }
    }

    void Blink()
    {
        timer += Time.fixedDeltaTime;
        if(timer>=0.25f)
        {
            light.intensity = Random.Range(0, 15f);
            timer = 0;
        }
    }
}
