using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimePointImfo : MonoBehaviour
{
    [SerializeField] Finish finish;
    float timePoint;
    public Timer timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timePoint = timer.maxTime;
            finish.AddTime(timePoint);
            Destroy(gameObject);
        }
    }
}
