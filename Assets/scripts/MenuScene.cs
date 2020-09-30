using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    public GameObject steve;
    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;
    public void Start()
    {
        fadeGroup = FindObjectOfType<CanvasGroup>();
        fadeGroup.alpha = 1;
    }

    private void Update()
    {
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;
        if(fadeGroup.alpha == 0)
        {
            Destroy(steve);
            Destroy(this);
        }
    }
}
