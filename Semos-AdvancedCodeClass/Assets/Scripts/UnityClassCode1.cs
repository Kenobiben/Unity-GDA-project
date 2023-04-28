using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityClassCode: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Ispecati gi broevite od 1 do 10

        //for (int i = 1; i < 10; i++)
        //{
        //    Debug.Log(i); 
        //}

        // int age = 5; // deklaracija i inicijacija na promenliva
        // Debug.Log(age); // pecatenje na promenliva

        /*int[] ages1 = new int[] { 10, 11, 15, 20, 13, 3 }*/; // nacin na 1 inicijacija
                                                               //int[] ages2 = new int[5]; // nacin na 2 inicijacija

        //Debug.Log(ages1[2] * ages2[2]);

        // // So pomos na ciklus, ispecatete gi site elementi od dvete nizi. 

        // for (int i = 0; i < ages1.Length; i++)
        // {
        //     Debug.Log(ages1[i]);
        // }
        // Debug.Log("");
        // for(int i = 0; i < ages2.Length; i++)
        // {
        //     Debug.Log(ages2[i]);
        // }

        // 2. DA gi ispecatime site elemeti od niza vo obraten redosled

        //for (int i = ages1.Length -1; i >= 0 ; i--)
        //{
        //    Debug.Log(ages1[i]);
        //}

        //3. Kreirajte nova niza ages3
        //int[] ages3 = new int[ages1.Length];
        // a. i ispolte ja so istite elementi kako nizata ages1
        // b. so kvadratite od elementit od nizata ages1 -> 100, 121, 225, 400, 169, 9 
        // c. presmetaj ja sumata na elementite od a i b

        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    ages3[i] = ages1[i] * ages1[i];
        //    Debug.Log(ages3[i]);
        //}
        //int suma1 = 0;
        //int suma2 = 0;

        //for (int i = 0; i < ages3.Length; i++)
        //{
        //    suma1 += ages1[i];
        //    suma2 += ages3[i];
        //}
        //Debug.Log($"{suma1} { suma2}");

        //4 napisi programa koja go naoga najgolemiot i najmaliot element od nizata
        //int[] ages1 = new int[] {24, 455, 32, 18, 4, 12 };
        //if (ages1.Length == 0)
        //{
        //    Debug.Log("Vashata niza e prazna");
        //}
        //else
        //{
        //    int bigElm = ages1[ages1.Length -1];
        //    int smallElm = ages1[ages1.Length -1];
        //    for (int i = 1; i < ages1.Length; i++);
        //    {
        //        int i = 0;
        //        if (ages1[i] > bigElm)
        //        {

        //            bigElm = ages1[i];
        //        }
        //        if (ages1[i] < smallElm)
        //        {
        //            smallElm = ages1[i];
        //        }
        //    }

        //    Debug.Log("biggest " + bigElm);
        //    Debug.Log("smallest " + smallElm);

        //{ (1 * 1 * 1), (2 * 2 * 2), (3 * 3 * 3), (4 * 4 * 4), (5 * 5 * 5) } | 1, 8,,, ..125

        //int[] array = new int[5];
        //for (int i = 1; i < array.Length; i++) // dpdeluvanje vrednosti na nizata
        //{
        //    array[i] = i * i * i;
        //}
        //int[] array = new int[5];
        //for (int i = 0; i < 5; i++)
        //{
        //    array[i] = (i + 5) * (i + 5) * (i + 5);
        //}


        //// pecatenje na niza
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Debug.Log(array[i]);
        //}





    }











}

    



