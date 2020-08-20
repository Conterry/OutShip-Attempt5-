using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ships : MonoBehaviour
{

    public GameObject Ship1;
    public GameObject MainCamera;
    private Vector3 TouchPlace;
    private Vector3 ShipPlace;


    private void Start()
    {

    }

    
    private void Update()
    {
        if(CanPlay())
        {
            MainCamera.transform.Translate(Vector3.forward * 1);
            ReadTouchX();
            ReadShipPlaceX();
            if(ShipPlace.x != TouchPlace.x)
            {
                if(ShipPlace.x < TouchPlace.x)
                {
                    Ship1.transform.position += new Vector3(+1, 0, 0);
                }
                else
                {
                    Ship1.transform.position += new Vector3(-1, 0, 0);
                }

            }

        }
    }

    bool CanPlay() {
        GameObject Button = GameObject.Find("Panel");
        StartButton startButton = Button.GetComponent<StartButton>();
        bool CanStart = startButton.CanStartGame;
        return CanStart==true;
    }

    public void ReadTouchX()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            TouchPlace.x = touch.position.x;
        }
        
    }

    public void ReadShipPlaceX()
    {
        ShipPlace.x = Ship1.transform.position.x;
    }

}
