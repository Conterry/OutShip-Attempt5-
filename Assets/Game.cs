﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    private bool CanStart = false;
    private int a = 0;
    
    
    void Update()
    {
        if (CanStart == false)
        {
            GameObject Button = GameObject.Find("StartButton");
            StartButton startButton = Button.GetComponent<StartButton>();
            CanStart = startButton.CanStartGame;
        }
        else
        {
            if (a != 1)
            {
                a++;
                StartGameProcess();
            }

        }
    }

    private void StartGameProcess()
    {

    }


}
