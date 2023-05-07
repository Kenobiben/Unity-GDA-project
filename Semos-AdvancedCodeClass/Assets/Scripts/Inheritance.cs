using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour
{

    private void Start()
    {
        //Roditel parent = new Roditel("blonde", "green", 175);
        //parent.Jump();

        //Dete child1 = new Dete();
        //child1.Jump();

        //Dete child2 = new Dete("black", "yellow", 70);
        //child2.Jump();
        //child2.eyeColor = "blue";
        //child2.height = 25;
        //child2.school = "Ekonomsko";
        // child2.gender = "masko";

        // koga rabotime so abstract klasa, od nea ne mozeme da kreirame instanci/objekti
        //AbstractRoditel abstractParent = new AbstractRoditel(); //-- ova ne funkcionira 
        //DeteOdAbstractRoditel deteOdAvstractRoditel = new DeteOdAbstractRoditel();
        //deteOdAvstractRoditel.Learn(); 

        //PartialClassTest pct = new PartialClassTest();
        //pct.Test();
        
    } 


}

class Roditel
{
    public string skinColor;
    public string eyeColor;
    public int height;
    protected string gender; //moze da se pristapvua vo klasi koi nasleduvaat od ovaa klasa (private, bool)
    private bool test; 
    public Roditel (string skinColor, string eyeColor, int height)
    {
        // this znaci promenliva sto se naogja vo klasata
        this.skinColor = skinColor; 
        this.eyeColor = eyeColor;
        this.height = height;
    }


    public void SetSkinColor(string sC)
    {
        this.skinColor = sC;
    }

    public void GiveBirht()
    {
        if (gender == "female")
        {
            // ;... 
        }
    }
    // virtual ovozmozuva da prezapisteme 
    public virtual void Jump() // virtual e zbor koj ja prezapisuva funkcijata
    {
        Debug.Log("Roditel : Jump");
    }

    public void Learn()
    {

    }
    public void Teach()
    {

    }

}
// nasleduva od 
class Dete : Roditel // dete koja nasleduva od klasata Roditel
{
    public string school;
    public Dete(string skinColor, string eyeColor, int height) : base (skinColor, eyeColor, height)
    {

    }

    public Dete() : base("", "", 150)
    {

    }

    private void Test()
    {
        gender = "Male"; 
    }

    //overide ja prezapisuva funkcijata od roditelot 

    public override void Jump()
    {
       // base.jump();
        Debug.Log("Dete:Jump");
    }
}

// postoi nacin kako od nekoja klasa da ne moza da kreirame instanci

abstract class AbstractRoditel
{
    public string skinColor;
    public string eyeColor;

    public virtual void Jump() // virtual e zbor koj ja prezapisuva funkcijata
    {
        Debug.Log("Roditel : Jump");
    }

    public abstract void Learn(); // abstractni funkcii nemaat nikakva implementacija
    // nivnata implementacija treba da bide vo dete klasata
   

    
}

class DeteOdAbstractRoditel : AbstractRoditel
{
    public override void Learn()
    {
        //base.Learn();// ne e vozmosno da se povika base abstract funkcija
        Debug.Log("Learning");
    }

    public override void Jump()
    {
        base.Jump();
    }


}

class A // po default ovaa klasa nasleduva od objeck klasa od C#
{ 

}


// klasa od koja e zabraneto da se nasleduva

//sealed class ZabranetoNasleduvanje
//{

//}

//class Test : ZabranetoNasleduvanje // ni dava greska, sealed klasa ne moze da ja povikas
//{

//}
//partial class PartialClassTest
//{
//    public int pt1;
//    public string pt2;
//}