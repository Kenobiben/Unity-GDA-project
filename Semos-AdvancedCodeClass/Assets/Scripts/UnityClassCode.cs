using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityClassCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ispecati gi broevite od 1 do 10

        //for (int i = 1; i < 10; i++)
        //{
        //    Debug.Log(i); 
        //}

        int age = 5; // deklaracija i inicijacija na promenliva
        Debug.Log(age); // pecatenje na promenliva

        int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 }; // nacin na 1 inicijacija
        int[] ages2 = new int[5]; // nacin na 2 inicijacija

       Debug.Log(ages1[2] * ages2[2]);
        
        // So pomos na ciklus, ispecatete gi site elementi od dvete nizi. 

        for (int i = 0; i < ages1.Length; i++)
        {
            Debug.Log(ages1[i]);
        }
        Debug.Log("");
        for(int i = 0; i < ages2.Length; i++)
        {
            Debug.Log(ages2[i]);
        }













    }

    


}
