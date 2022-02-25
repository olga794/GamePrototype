using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Image bluescreen;
    public float fadeSpeed;
    public bool fadeToBlack, fadeFromBlack;
    // agregar al  canvas
    public Text TexHearlth;

    private void Awake()
    {
        Instance =  this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeToBlack)
        {
            bluescreen.color = new Color(bluescreen.color.r, bluescreen.color.g, bluescreen.color.b,
                Mathf.MoveTowards(bluescreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if (bluescreen.color.a == 1f)
            {
                fadeToBlack = false;
            }
        }
        if (fadeFromBlack)
        {
            bluescreen.color = new Color(bluescreen.color.r, bluescreen.color.g, bluescreen.color.b,
                Mathf.MoveTowards(bluescreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (bluescreen.color.a == 0f)
            {
                fadeFromBlack = false;
            }
        }

        
    }
}