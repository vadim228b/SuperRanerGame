using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float maxTime = 0f;
    public TMP_Text textTime;
    float realTime;

    public bool isTimerRuning = true;
    private void Start()
    {
        textTime.text = maxTime.ToString("F3");
    }

    private void Update()
    {
        if (isTimerRuning == true)
        {
            maxTime += Time.deltaTime;
            textTime.text = maxTime.ToString("F3");
        }
    }
}
