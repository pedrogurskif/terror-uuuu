using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LightsOut : MonoBehaviour
{
    public Light light;
    public AudioSource som;
    public AudioSource blink;
    private float timer = 0f;
    private float timerDie = -0.0001f;
    public bool thatLight = false;
    public bool playSoundCheck = true;
    public bool shatterSoundCheck = false;
    public bool check = false;
    public Light directLight;
    void Start()
    {
        light = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        if(check)
        {
            timerDie += Time.deltaTime;
        }
        Debug.Log(timerDie);
        if(timerDie > 0 && playSoundCheck == false)
        {
            blink.Play();
            playSoundCheck = true;
        }
        if(timerDie >= 0 && timerDie < 10)
        {
            Blink(0.05f, 0f, 8f);         
        }
        else if(timerDie >= 10 && !thatLight && shatterSoundCheck == false)
        {
            light.intensity = 0;
            som.Play();
            directLight.color = Color.black;
            shatterSoundCheck = true;
        }
        else if(timerDie>= 10 && thatLight)
        {
            blink.Stop();
            Blink(0.15f, 0f, 5f);
        }
    }

    void Blink(float cd, float botLim, float topLim)
    {
        timer += Time.deltaTime;
        if(timer>=cd)
        {
            light.intensity = Random.Range(botLim, topLim);
            timer = 0;
        }
    }

    public void giveCheck()
    {
        check = true;
    }
}
