using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Finish : MonoBehaviour
{
    [Header("UI")]
    [SerializeField, Tooltip("Окно")] GameObject staticticPanel;
    [SerializeField, Tooltip("text")] TMP_Text textFinalTime;
    [SerializeField] TMP_Text jumpPanel;
    [SerializeField] TMP_Text downPlatformPanel;
    [SerializeField] TMP_Text lungePanel;

    [SerializeField] Timer timer;
    [SerializeField] float finishTime;
    [SerializeField] Image finishPanel;
    public List<float> timePoint;
    public GameObject prefabsTimePanel;
    [SerializeField] GameObject contentMenu;

    [Header("Количество действий")]
    [HideInInspector] public int nJump;
    [HideInInspector] public int nDownPlatform;
    [HideInInspector] public int nLunge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer.isTimerRuning = false;
            finishTime = timer.maxTime;
            Time.timeScale = 0f;
            textFinalTime.text = "Ваше время: " + finishTime.ToString("F3");
            staticticPanel.SetActive(true);
            finishUI();
        }
    }

    private void Start()
    {
        staticticPanel.SetActive(false);
    }

    public void AddTime(float time)
    {
        GameObject prefabsPanel = Instantiate(prefabsTimePanel);
        prefabsPanel.transform.parent = contentMenu.transform;
        prefabsPanel.transform.localScale = new Vector3(1, 1, 1);

        var timePrefabPanel = prefabsPanel.transform.Find("Text").GetComponent<TMP_Text>();
        timePrefabPanel.text = time.ToString("F3");
    }

    public void RestartGame()
    {
        
    }

    void finishUI()
    {
        jumpPanel.text = nJump.ToString();
        downPlatformPanel.text = nDownPlatform.ToString();
        lungePanel.text = nLunge.ToString();
    }
}
