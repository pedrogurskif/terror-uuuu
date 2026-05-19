using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public Animator door;
    public AudioSource doorSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            door.Play("fecha");
            doorSound.Play();
            Destroy(gameObject);
        }
    }
}
