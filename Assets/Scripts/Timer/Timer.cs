using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//How to use:
//Place on any GameObject
//Make a UI TextMeshPro element and link it in the timerText variable

//Script by Matthew Bridgeman

public class Timer : MonoBehaviour
{
    public static Timer instance;

    [Range(0, 600)]
    [SerializeField] private float startTime = 120;
    public float remainingTime;

    [SerializeField] private TextMeshProUGUI timerText;

    [SerializeField] private bool timerActive;

    public void Start()
    {
        instance = this;
        remainingTime = startTime;
    }

    void Update()
    {
        if (timerActive) remainingTime -= Time.deltaTime;
        timerText.text = Mathf.RoundToInt(remainingTime).ToString();

        if (remainingTime <= 0)
        {
            UIManager.instance.OutOfTime();
            Time.timeScale = 0;
        }
    }

    public void StartTimer()
    {
        timerActive = true;
    }
    public void PauseTimer()
    {
        timerActive = false;
    }
}
