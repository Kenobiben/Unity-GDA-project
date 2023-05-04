using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes2 : MonoBehaviour // unity klasa 
{

    private void Start()
    {
        // instancirame - kreirame objekti od taa klasa 
        SomeClass class1 = new SomeClass(5,6,7);
        //class1.someInt = 5;
        //class1.someInt2 = 6; 
        //class1.someInt3 = 7;
        class1.SomeFunction();

        // nov objekt
        SomeClass class2 = new SomeClass();  // konstuktor - inicijalizacija na objekt pri negova inicijacija

    }


    // Deklariranje na klasa

    class SomeClass
    {
        public int someInt; // dokolku promenliva e public, moze da pristapime nadvor od klasata
        public int someInt2;
        public int someInt3;

        // default konstruktor - bez parametri
        public SomeClass() 
        {
            someInt = 0;
            someInt2 = 0;
            someInt3 = 0;  
        }


        // konstruktor - pocnuva so public pa ime na klasa pa promenlivi koi sakame da gi inicjalizirame
        public SomeClass(int si1, int si2, int si3) // konstruktor so 3 promenlivi 
        {
             // ja prima vrednosta o
            someInt = si1;
            someInt2 = si2;
            someInt3 = si3;

        }





        public void SomeFunction()
        {

        }

    }












}
