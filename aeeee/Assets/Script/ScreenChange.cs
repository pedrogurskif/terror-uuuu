using UnityEngine;

public class ScreenChange : MonoBehaviour
{
    public Renderer render;
    public Material matA, matB, matC, matGlitch;
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
        if(timer >= 3f && checkA == false)
        {
            checkA = true;
            render.material = matGlitch;
        }
        if(timer >= 4f && checkB == false)
        {
            checkB = true;
            render.material = matB;
        }
        if(timer >= 7 && checkC == false)
        {
            checkC = true;
            render.material = matGlitch;
        }
        if(timer >= 8 && checkD == false)
        {
            checkD = true;
            render.material = matC;
        }
    }

    public void Go()
    {
        check = true;
    }
}
