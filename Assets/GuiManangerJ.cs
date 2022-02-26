using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiManangerJ : MonoBehaviour
{
    public static GuiManangerJ instance;
    public Image vistaNegra;
    public float fadeSpeed;
    public bool fadeToBlack, fadeFromBlack;

    private void Awake()
    {
        instance =  this;
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
            vistaNegra.color = new Color(vistaNegra.color.r, vistaNegra.color.g, vistaNegra.color.b,
                Mathf.MoveTowards(vistaNegra.color.a, 1f, fadeSpeed * Time.deltaTime));
            if (vistaNegra.color.a == 1f)
            {
                fadeToBlack = false;
            }
        }
        if (fadeFromBlack)
        {
            vistaNegra.color = new Color(vistaNegra.color.r, vistaNegra.color.g, vistaNegra.color.b,
                Mathf.MoveTowards(vistaNegra.color.a, 1f, fadeSpeed * Time.deltaTime));
            if (vistaNegra.color.a == 1f)
            {
                fadeFromBlack = false;
            }
        }

        
    }
}
