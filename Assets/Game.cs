using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    private bool CanStart = false;
    
    void Update()
    {
        

        if (CanStart == false)
        {
            GameObject Button = GameObject.Find("Panel");
            StartButton startButton = Button.GetComponent<StartButton>();
            CanStart = startButton.CanStartGame;
        }
        else
        {
            





        }
    }


}
