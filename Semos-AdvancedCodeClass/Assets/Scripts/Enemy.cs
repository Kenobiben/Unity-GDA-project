using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speed = 1;
    public float rotationSpeed = 0.5f;

  
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(false); 
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(false);
        }


        //transform.Translate(-Vector3.forward * speed * Time.deltaTime); // neame uceno ova

        // koga ke drzite na strelkata nagore, enemy objektod da se dvizi napred
        // Move();
        // sp drzenje left i right arrow objektot da se rotira levo/desno

    }

    private void Move(bool moveforwoard)
    {
        Vector3 position = transform.position;
        position.z -= (moveforwoard ? -1 : 1)* speed * Time.deltaTime;
        transform.position = position;
    }

    private void Rotate(bool rotateLeft)
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += (rotateLeft ? -1 : 1) * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = rotation;
    }

    // kodot so dvizenje stavete go vo funkicja move

}
