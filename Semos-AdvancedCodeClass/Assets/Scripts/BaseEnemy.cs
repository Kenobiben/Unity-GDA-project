using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ENCAPSULACIJA - klasite da bidat skrieni / koncept vo objektno orientirano programiranje
// koj ni ukazuva deka site klasi treba ad bidat zatvoreni kolku sto moze povekje. 
public abstract class BaseEnemy : MonoBehaviour
{
    [SerializeField]  // ovozmozuva da imas pogolema zastita na promenlivi koi se dodavani vo unity.
    private float speed = 10; // promenliva
    [SerializeField]
    private int health = 100;
    [SerializeField]
    protected Rigidbody rb; // protected moze da zastiti i da vlece fajl vo druga skripta
    [SerializeField]
    protected float jumpForce = 1;

    public void Move() // dvizenje
    { 
        Vector3 position = transform.position;
        position.z -= speed * Time.deltaTime;
           transform.position = position;
     }

    public virtual void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce);
    }

    private  void Die()
    {
        //Destroy(gameObject); //--validen 
        gameObject.SetActive(false);
    }
    private void DecreaseHealth()
    {
        health--;
        if (health == 0)
        {
            Die();
        }
    }


 }
   
