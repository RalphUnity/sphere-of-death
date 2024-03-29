﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{

    float currentTime = 0f;
    float startingTime = 60f;
    public GameObject boss;
    public GameObject bossHealthBar;

    public TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        int seconds = (int)(currentTime % 60);
        int minutes = (int)(currentTime / 60) % 60;
       

        countdownText.text = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (currentTime <= 0)
        {
            currentTime = 0;
            boss.SetActive(true);
            bossHealthBar.SetActive(true);
        }
    }
}
