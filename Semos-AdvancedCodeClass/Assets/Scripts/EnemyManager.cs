using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //[SerializeField]
    //private TelleportEnemy tpEnemy;
    //[SerializeField]
    //private BlinkinEnemy blinkEnemy;
    //[SerializeField]
    //private ScalingEnemy scalingEnemy;
    [SerializeField]
    private BaseEnemy[] enemies;

    public bool gameStart = false; // bool e sekogas false 

    // koga ke klikeneme na kopceteo play, da pocneme od ovde da ja povikuvame funkcijata Move od Enemy.

    private void Update()
    {
        if (gameStart)
        {
            //tpEnemy.Move();
            //blinkEnemy.Move();
            //scalingEnemy.Move();
            for ( int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Move(); // za sekoj enemy move - optimiziran
            }
           
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
 