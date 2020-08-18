using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    private bool CanStart = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CanStart == false)
        {
            GameObject Button = GameObject.Find("StartButton");
            StartButton startButton = Button.GetComponent<StartButton>();
            CanStart = startButton.CanStartGame;
        }
        {
            GameProcess();
        }
    }

    private void GameProcess()
    {

    }


}
