using UnityEngine;
using UnityEngine.UI;

public class ScreenChange : MonoBehaviour
{
    public Renderer render;
    public Material matA, matB, matC, matGlitch;
    public AudioSource som;
    public bool check = false;
    public bool checkA, checkB, checkC, checkD = false;
    public float timer = 0;
    public Renderer renderer;
    public bool aaaaa = false;
    public Graphic image;
    private float alphaVal;
    public bool checkView = false;
    void Start()
    {
        
    }

    void Update()
    {
        if(checkView)
        {
            Debug.Log("visivel");
        }
        else
        {
            Debug.Log("nao visivel");
        }
        if(check)
        {
            timer += Time.deltaTime;
        }
        if(timer >= 4f && checkA == false)
        {
            checkA = true;
            som.volume = 0.18f;
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
            som.volume = 0.18f;
            render.material = matGlitch;
        }
        if(timer >= 10 && checkD == false)
        {
            checkD = true;
            som.volume = 0.01f;
            render.material = matC;
        }
        if(checkD && checkView)
        {
            aaaaa = true;
        }
        if(alphaVal >= 2f)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    void FixedUpdate()
    {
        if(aaaaa)
            {
                alphaVal += 0.2f;
                image.color = new Color(0, 0, 0, alphaVal);
            }
    }


    public void Go()
    {
        check = true;
    }

    public void CHECKVIEW(bool check)
    {
        checkView = check;
    }
}
