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
    protected float jumpForce = 1;
    [SerializeField]
    protected Rigidbody rb; // protected moze da zastiti i da vlece fajl vo druga skripta




    public virtual void Move(Vector3 targetPosition) // dvizenje
    {
        //Vector3 position = transform.position;
        //position.z -= speed * Time.deltaTime;
        //   transform.position = position;

        //logika so ke go dvizi ovoj enemy objekt kon pozicija moveTowards
        Vector3 position = transform.position;
        position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);
        transform.position = position;


        //Vector3.Distance(); // funkcija koja vrakja rastojanie pomegju dva objekti 

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
   
