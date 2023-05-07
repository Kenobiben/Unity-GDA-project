using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Patient // nova klasa 
{
    public string name;
    public string surname;
    public int birthYear;
    public string[] illnessHistory;
    public long idNumber;
    public string gender;


    public Patient() // konsturktor default 
    {
        name = "";
        surname = "";
        birthYear = 1950;
    }

    public Patient(string n, string s) // konstruktor so ime i preziem 
    {
        name = n;
        surname = s;
    }

    public Patient(string n, string s, int brt, string[] ill, long id, string g) // konstruktor so site promenlivi od klasata 
    {
        name = n;
        surname = s;
        birthYear = brt;
        illnessHistory = ill;
        idNumber = id;
        gender = g;
    }


    // string GetFullName() - funckijata vi vraka ime i prezime (ne pecati tuku vraka, return)

    public void PrintFullName()  // void znaci deka ne vrakja nisto
    {
        Debug.Log(name + " " + surname);
    }

    public string GetFullName()
    {
        return name + " " + surname;
    }

    // bool IsUnderage - proveruva dali pacientot e maloleten i vraka true/ vo sprotivno false
    public void PrintUnderage() // da se proveri pod 18
    {
        int currentYear = System.DateTime.Now.Year; // sistemski dodavanje realen datum
        Debug.Log(currentYear);
        if (currentYear - birthYear < 18)
        {
            Debug.Log("Pacientot e maloleten");
        }

        else

        {

            Debug.Log("Pacientot ne e maloleten");
        }



    }
    public bool IsUnderage()
    {
        int currentYear = System.DateTime.Now.Year; // proverka na godina
        if (currentYear - birthYear < 18)
        {
            return true;
        }
        else
        {
            return false;
        }



    }

    // vpod PrintIllnesses() - ja pecati celata istorija na bolesti na pacientot
    public void PrintIllnesses()
    {
        for (int i = 0; i < illnessHistory.Length; i++)
        {
            Debug.Log(illnessHistory[i]);
        }
    }

    // void AddIllness(sting newIllness) - dodava nova bolest vo niza so bolesti

    public void AddIllness(string newIllness)
    {
        // vo niza illneshistori treba da ja dodadme newillness
        // 1 kreiranje nova niza so n+1 elemeniti
        string[] updateIllnessHistory = new string[illnessHistory.Length + 1];
        // 2 prekopiranje na postoecki elementi
        for (int i = 0; i < illnessHistory.Length; i++)
        {
            updateIllnessHistory[i] = illnessHistory[i];
        }

        // 3 dodavenje na noviot element na krajot od nizata 

        updateIllnessHistory[illnessHistory.Length] = newIllness;

        // 4 dodeli ja vrednosta na novata niza na promenlivata illness history

        illnessHistory = updateIllnessHistory;

    }

}

  













