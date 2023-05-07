using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classes3 : MonoBehaviour
{
    /// --  objasnuvanje za value type
    private void Start()
    {
        //Number object1 = new Number();
        //object1.num = 5;

        //Number object2 = object1; // 2te promenlivi imaat ista referenca
        //object2.num = -5;

        //Debug.Log(object1.num);

        /// --- objasnuvanje za reference type 
        //string string1 = "Hello World";
        //string string2 = string1;
        ////string2 = "";
        ////string1 = "H";

        //string2 = "";
        //if (string2 !=null) // dokolku ima referenca
        //{
        //    Debug.Log(string2);

        //}
        // Debug.Log(string1);
        // Debug.Log(string2);

        // string1?
        // string2? 

        //Number object1 = new Number();
        //object1.num = 10;
        //Test1(object1); // prakjanje na objekt po referenca
        //Debug.Log(object1.num);
        // num e 11 - se zacuvuvaat objekti so referenca

        //int number = 3;
        //Test2(number);
        //Debug.Log(number);

        string someString = "Hello World";
        Test3(someString);
        Debug.Log(someString);
    }
     
    private void Test1(Number number)
    {
        number.num = 11; 
    }

    private void Test2(int number) // vrednosta e od tip int, i vrednosta avtomatski se duplira
    {
        number = 0;
    }

    private void Test3(string s)
    {
        s = ""; 
    }
}

class Number
{
    public int num; // ako se smeni tuka - ke se smeni gore 
}