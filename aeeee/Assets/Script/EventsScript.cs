using UnityEngine;

public class EventsScript : MonoBehaviour
{
    public AudioSource knock, heartbeat;
    private float timer = -12;
    private float playBackThreshold;
    private bool check = false;
    private bool startCount = false;
    public LightsOut light0, light1, light2, light3, light4, light5, light6, light7, light8, light9;
    public SlamCode slam;
    void Start()
    {
        playBackThreshold = Random.Range(5.01f, 10f);
    }

    void Update()
    {
        if(check)
        {
            timer += Time.deltaTime;
            Knock();
        }
        if(startCount)
        {
            heartbeat.volume = 0.06f;
            if(timer>-6)
            {
                light0.giveCheck();
                light1.giveCheck();
                light2.giveCheck();
                light3.giveCheck();
                light4.giveCheck();
                light5.giveCheck();
                light6.giveCheck();
                light7.giveCheck();
                light8.giveCheck();
                light9.giveCheck();
                slam.getCheck();
                startCount = false;
                heartbeat.volume = 0.09f;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if(check==false)
            {
                startCount = true;
                check = true;
            }
        }
    }

    private void Knock()
    {
        if(timer>playBackThreshold)
        {
            knock.volume = Random.Range(0.081f, 0.201f);
            knock.pitch = Random.Range(0.699f, 1.311f);
            knock.Play();
            playBackThreshold = Random.Range(5.01f, 10f);
            timer = 0;
            heartbeat.volume = 0.13f;
            heartbeat.pitch = 1.6f;
        }
    }
}
