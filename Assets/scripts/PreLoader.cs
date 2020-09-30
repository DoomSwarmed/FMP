using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreLoader : MonoBehaviour
{
    private CanvasGroup fadegroup;
    private float loadTime;
    private float logoTime = 3.0f;

    private void Start()
    {
        fadegroup = FindObjectOfType<CanvasGroup>();

        fadegroup.alpha = 1;
        if (Time.time < logoTime)
            loadTime = logoTime;
        else
            loadTime = Time.time;
    }

    private void Update()
    {
       if (Time.time < logoTime)
        {
            fadegroup.alpha = 1 - Time.time;
        }

       if (Time.time > logoTime && loadTime != 0)
        {
            fadegroup.alpha = Time.time - logoTime;
            if(fadegroup.alpha >= 1)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}   
