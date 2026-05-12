using UnityEngine;

public class LightsOut : MonoBehaviour
{
    [SerializeField] private Light lightComponent;
    void Start()
    {
        InvokeRepeating("lightOut", 2, 0.01f);
        lightComponent = gameObject.GetComponent<Light>();
    }

    void Update()
    {
        
    }

    public void lightOut()
    {
        lightComponent.intensity = Random.Range(0f, 1.6f);
    }
}
