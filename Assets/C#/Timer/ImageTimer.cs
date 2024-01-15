using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ImageTimer : MonoBehaviour
{
    [SerializeField] private float MaxTime;
    [SerializeField] private UnityEvent timeOver;
    private Image img;
    private float currentTime;

    void Start()
    {
        img = GetComponent<Image>();
        currentTime = 0.0f;
    }


    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= MaxTime)
        {
            timeOver.Invoke();
            currentTime = 0.0f;
        }
        img.fillAmount = currentTime / MaxTime;
    }
}



