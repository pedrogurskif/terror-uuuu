using UnityEngine;

public class ScreenChange : MonoBehaviour
{
    public Renderer render;
    public Material matA, matB, matC, matGlitch;
    public AudioSource som;
    public bool check = false;
    public bool checkA, checkB, checkC, checkD = false;
    public float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if(check)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 4f && checkA == false)
        {
            checkA = true;
            som.volume = 0.1f;
            render.material = matGlitch;
        }
        if(timer >= 5f && checkB == false)
        {
            checkB = true;
            som.volume = 0.01f;
            render.material = matB;
        }
        if(timer >= 9 && checkC == false)
        {
            checkC = true;
            som.volume = 0.1f;
            render.material = matGlitch;
        }
        if(timer >= 10 && checkD == false)
        {
            checkD = true;
            som.volume = 0.01f;
            render.material = matC;
        }
    }

    public void Go()
    {
        check = true;
    }
}
