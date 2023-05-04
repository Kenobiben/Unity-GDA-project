using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes : MonoBehaviour
{
    // 2 nizi vo klasa na MonoBehaviour

    public string[] Names;
    public int[] Ages; 



     private void Start() //main
    {
        // kreirajte instanca od taa klasa

        
        Person person = new Person(); // kreirawe na objekt ili istanca na klasa 
        // inicijalizirajte gi ovde za objektot person 
        person.name = "Pero";
        person.age = 5;

        // povikajte ja taa funkcija od tuka 

        // klasa / funkcija (objasnuvanje za povikuvanje na fukcija)
        person.PrintNameAndAge();



        Person[] students = new Person[Names.Length];

        
        //students[0] = new Person(); // kreiranje objekt od tip Person i dodeluvanje na taa vrednost vo prv element od nizata students
        //students[0].name = Names[0]; // dodeluvnaje ime na prviot objekt;
        //students[0].age = Ages[0]; // dodeluvanje na vozrast na prviot objekt. 

        //students[1] = new Person();
        //students[1].name = Names[1];
        //students[1].age = Ages[1];

        //students[2] = new Person();
        //students[2].name = Names[2];
        //students[2].age = Ages[2];

        //students[3] = new Person();
        //students[3].name = Names[3];
        //students[3].age = Ages[3];

        // istiot code vo for ciklus
        for ( int i = 0; i <= students.Length; i++)
        {
            students[i] = new Person();
            students[i].name = Names[i];
            students[i].age = Ages[i];
        }

        // ispecati gi imianja na site student i vozrasta
        //students[0].PrintNameAndAge();
        //students[1].PrintNameAndAge();
        //students[2].PrintNameAndAge();
        //students[3].PrintNameAndAge();

        // pecatenje vo for 
                            // students lenght - dolzina na array mesto broj
        for (int i = 0; i <= students.Length; i++)
        {
            students[i].PrintNameAndAge();
        }





    }

    // napisete klasa po vas izbor
    
    class Person
    {
        // dodadete 2 promenlivi 
        public string name;
        public int age;

        // kreirajte funkcija 
        // void funkcija sto se vika PrintNameAndAge i ke pecati ime i vozrast vo edna linija. 

        public void PrintNameAndAge() // deklariranje na funkcija
        {
            // telo na fukcija
            Debug.Log(name + " " + age);  
        }


    }







}
