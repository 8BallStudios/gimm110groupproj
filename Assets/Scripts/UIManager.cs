using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject timeOutScreen;

    public static UIManager instance;

    public void Start()
    {
        instance = this;
    }

    public void Win()
    {
        winScreen.SetActive(true);
    }

    public void Lose()
    {
        loseScreen.SetActive(true);
    }

    public void OutOfTime()
    {
        timeOutScreen.SetActive(true);
    }
}
