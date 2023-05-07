using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TelleportEnemy tpEnemy;
    [SerializeField]
    private BlinkinEnemy blinkEnemy;

    public bool gameStart = false; // bool e sekogas false 

    // koga ke klikeneme na kopceteo play, da pocneme od ovde da ja povikuvame funkcijata Move od Enemy.

    private void Update()
    {
        if (gameStart)
        {
            tpEnemy.Move();
            blinkEnemy.Move();
           
        }

        //// testirame skokanje
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    //Debug.Log("GetKeyDown");
        //    tpEnemy.Jump();
        //}
        
    }

    public void PlayPressed()
    {
        gameStart = true;
    }

}
 