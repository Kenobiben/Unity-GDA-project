using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private TelleportEnemy enemyPrefab;
    [SerializeField]
    private BaseEnemy[] enemies;
    [SerializeField]
    private Transform player;

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
                if (enemies[i] != null)
                {
                    // izbrisi go od nizata
                    // brisi go elementot so index i 
                    // prodolzi so ciklusot
                    continue; //vs break;
                }

                enemies[i].Move(player.position); // za sekoj enemy move - optimiziran
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
        if (gameObject.activeInHierarchy)
        StartCoroutine(DynamicSpawn());
    }
    
    private IEnumerator DynamicSpawn()
    {
        while (true)
        {
            Vector3 pos = new Vector3(Random.Range(-1f, 1f), 1f, Random.Range(-1f, 1f));
            BaseEnemy enemyInstance = Instantiate(enemyPrefab, pos, Quaternion.identity);
            enemyInstance.gameObject.SetActive(true);
            // enemyInstance treba da go stavime vo nizata

            BaseEnemy[] tmp = new BaseEnemy[enemies.Length + 1];
            // kopiranje na site elementi
            for (int i = 0; i < enemies.Length; i++)
            {
                tmp[i] = enemies[i];
            }
            tmp[enemies.Length] = enemyInstance; // go dodavame vo novata niza
            enemies = tmp; // promenlivata enemies ke pokazuva kon novata niza

            yield return new WaitForSeconds(.5f);
        }
        
    }



}
 