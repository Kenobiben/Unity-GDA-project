using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityClassCode2 : MonoBehaviour
{
    // kako da kreiram int promenliva
    //public int neznam = 0; // promenlivi  koi se del od klasata
    //public string name;
    //public char character;
    //public float decimalNumber;
    //public double doubleNumber;
    //public int[] array;
    //public GameObject[] objects;
    //public bool Test;

    // po default bool promenliva (vo klasa) ima vrednost false()0
    private bool isActive; // nie nemame zadadena vrednost za ovaa promenliva (isactive e false avtomatski) 

    public GameObject[] objects;
    public int hideElementIndex;

    // Start is called before the first frame update
    private void Start()
    {
        //int znam = 1; // lokalni promenlivi
        //              //Debug.Log(array);
        //int brojac = 0;
        //foreach (int element in array)
        //{
        //ako elementot e paren -> pecatio go
        //if (element % 2 == 0)
        //{
        //    Debug.Log(element);
        //}
        //    if (element % 2 == 1;
        //    {
        //        brojac++;
        //    }
        //}
        //Debug.Log(brojac);

        // izbori kolku neparni elementi ima vo nizata 
        //objects[0].SetActive(false);
        //objects[1].SetActive(false);

        //objects[hideElementIndex].SetActive(false);

        //hide random objects
        //for (int i = 0; i < objects.Length; i += 2)
        //{
        //    objects[i].SetActive(false);
        //}

    }
    // napisete kod so ke go isklucuva prviot object of nizata
    // objects koga ke stisneme na kopceto Q 

    private void Update() // funkcija koja se povikuva avtomatski od unity na sekoj frame
    {
        //if (Input.GetKeyDown(KeyCode.Q)) // dokolku klikneme na kopceto q od tastatura
        //{
        //    objects[0].SetActive(false); // iskluci go prviot object od nizata objects 
        //    //isActiveAndEnabled = false; // da se testira
        //}
        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    objects[0].SetActive(true);
        //}

        //if (Input.GetKeyDown(KeyCode.Q)) 
        //{
        //    // treba da proverime dali objektot e vklucen > iskluci
        //    if (isActive)
        //    {
        //        objects[0].SetActive(false); // iskluci
        //        isActive = false; // zapamti deka e isklucen
        //    }
        //    //treba da proverime dali objektot e isklicen -> vklucen
        //    else
        //    {
        //        objects[0].SetActive(true);
        //        isActive = true;
        //    }
        //    //objects[0].activeSelf

        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{               // izvicnikot menuva vrednost (true/false)
        //    // na pritiskanje na Q proveruva i isklucva..
        //    objects[0].SetActive(!objects[0].activeSelf); // skratena verzija na kod. 
        //}
        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    bool active = objects[0].activeSelf;
        //    objects[0].SetActive(!active);
    
        //}







    }





}
