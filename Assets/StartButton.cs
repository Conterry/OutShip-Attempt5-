using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{

    private Animator m_Animator;
    public string MiracleParamName;
    public bool CanStartGame;

    public void Start()
    {
        CanStartGame = false;
        m_Animator = GetComponent<Animator>();
        TurnMiracle(false);

    }

    public void OnClick()
    {
        TurnMiracle(true);
        CanStartGame = true;
    }


    private void TurnMiracle(bool bMiracle)
    {
        m_Animator.SetBool(MiracleParamName, bMiracle); 
    }

}
