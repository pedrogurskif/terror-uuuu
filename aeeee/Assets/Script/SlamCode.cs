using UnityEngine;

public class SlamCode : MonoBehaviour
{
    public AudioSource som;
    private bool check = false;
    private float timer, knockCD;
    void Start()
    {
        knockCD = Random.Range(4.501f, 8.001f);
    }

    // Update is called once per frame
    void Update()
    {
        if(check)
        {
            timer += Time.deltaTime;
            if(timer >= knockCD)
            {
                som.pitch = Random.Range(0.7f, 1.21f);
                som.Play();
                timer = 0;
                knockCD = Random.Range(4.501f, 8.001f);
            }
        }
    }

    public void getCheck()
    {
        check = true;
    }
}
