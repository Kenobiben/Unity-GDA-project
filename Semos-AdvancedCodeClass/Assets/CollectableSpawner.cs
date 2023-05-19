using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject collectablePrefab;
    [SerializeField]
    private float initalSpawnTimer1;
    [SerializeField]
    private float initalSpawnTimer2;


    private void Start()
    {
        StartCoroutine(CreateCollectables());
    }


    IEnumerator CreateCollectables()
    {

        while (true)
        {
            float randomNumber = Random.Range(initalSpawnTimer1, initalSpawnTimer2); // generira random broj
            yield return new WaitForSeconds(randomNumber); // vreme na cekawe na random number
           Vector3 position = new Vector3(Random.Range(-5f,5f), 1.18f, Random.Range(-5f, 5f));
            //Vector3 position = collectablePrefab.transform.position;
            //position.x = Random.Range(-5f, 5f);
            //position.z = Random.Range(-5f, 5f;

            GameObject collectableInstanciate = Instantiate(collectablePrefab, position, Quaternion.identity); // se kreira objekt od pefab i ne se rotira.  
            yield return new WaitForSeconds(5F);// cekame 5 sekundi

            if (collectableInstanciate != null) // proveruvame dokolku ne e unisten - null check
            {
                Destroy(collectableInstanciate); // se unusituva objektot koj se kreira 
            }
        }
        
    }

      
}
