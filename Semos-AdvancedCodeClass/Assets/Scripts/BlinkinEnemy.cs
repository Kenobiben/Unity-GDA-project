using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkinEnemy : BaseEnemy
{
    public MeshRenderer meshRenderer;

    // kako da go napravime da trepka
    private void Start()
    {
        // so pomos na korutina povikaj ja funkcijata Blink
        // korutina e fukcija koja moze da se pauzira vo sredina na izvrsuvanje, da izvrsi druga funkcija
        // a potoa da prodolzi od kade sto pauzirala.

        InvokeRepeating("Blink", 1, 1);
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
    