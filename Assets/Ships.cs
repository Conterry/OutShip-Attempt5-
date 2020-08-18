using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour
{
    GameObject Slider = GameObject.Find("ShipSlider");

    private void Start()
    {
        Slider.SetActive(false);
    }

    
    private void Update()
    {
        if(CanPlay())
        Slider.SetActive(true);
    }

    bool CanPlay() {
        GameObject Button = GameObject.Find("StartButton");
        StartButton startButton = Button.GetComponent<StartButton>();
        bool CanStart = startButton.CanStartGame;
        return true;
    }

}
