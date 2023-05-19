using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkinEnemy : BaseEnemy
{
    [SerializeField] // atribut od unity
    public MeshRenderer meshRenderer;

    // kako da go napravime da trepka
    private void Start()
    {
        // so pomos na korutina povikaj ja funkcijata Blink
        // korutina e fukcija koja moze da se pauzira vo sredina na izvrsuvanje, da izvrsi druga funkcija
        // a potoa da prodolzi od kade sto pauzirala.

        // InvokeRepeating("Blink", 1, 1);

        // TestCorutine(); // vaka se povikuva funkcija
        StartCoroutine(TestCorutine()); // vaka se povikuva korutina
    }

    public override void Move(Vector3 targetPosition)
    {
        base.Move(targetPosition);

        // dopolnitelno proverete dali playerot e blisku do enemy
    }

    //korutina
    private IEnumerator TestCorutine() // ako nema yild ima greska, 
    {
        // 
        //Blink();

        while (true)
        {
            //if (meshRenderer.enabled)
            //{ 
            //    yield return new WaitForSeconds(Random.Range(3f, 7f)); // pocekaj 5 secundi

            //}
            //else
            //{
            //    yield return new WaitForSeconds(Random.Range(1f, 2f)); // pocekaj 5 secundi

            //}
            //Blink();

            // na angel resenie 
            yield return new WaitForSeconds(Random.Range(3f, 7f)); 
            Blink();
            yield return new WaitForSeconds(Random.Range(1f, 2f)); 
            Blink();
        }


    }




    [ContextMenu("Blink")] // testira funkcija bez kod - implementiran vo unity--- za akces ... 

    public void Blink()
    {
        // dokolku renerer e vklucen, iskluci go / isklice/ vklcuen
        //meshRenderer.enabled = false; // .enable - ni vklucuva i uklucuva objekt, true/false

        //if (rend.enabled == false) //  = operator sza dodeluvanje na vrednost // == e operator za ednakvost
        //{
        //    rend.enabled = true;
        //}
        //else // koga e vklucen
        //{
        //    rend.enabled = false;
        //}

        // this is the way how you need to code. 
        //if (!meshrenderer.enabled)
        //{
        //    meshrenderer.enabled = false;

        //}
        //else
        //{
        //    meshrenderer.enabled = true;
        //} 


        //  meshRenderer.enabled = meshRenderer.enabled ? false : true; // optimalen code za blink so 

        meshRenderer.enabled = !meshRenderer.enabled; // optimiziran kod



    }




    
 }
    