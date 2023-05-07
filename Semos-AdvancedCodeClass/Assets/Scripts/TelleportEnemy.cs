using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelleportEnemy : BaseEnemy
{
    [SerializeField]
    private float teleportRange;

    private void Start()
    {
        // jumpForce *= 0.5f; -  
        // izvrsuvaj ja funkicjata teleport na sekoi 5 sekundi posle prviot pat (4 sek)
        InvokeRepeating("Teleport", 4, 5);
    }

    [ContextMenu("Teleport")] // funkcia za testiranje. vo skripta dodava nova funkcija za testiranje.

    private void Teleport()
    {
        // so dva pati pisan kod
        //Vector3 pos = transform.position;
        //pos.z += Random.Range(-teleportRange, teleportRange);
        //pos.x += Random.Range(-teleportRange, teleportRange);
        //transform.position = pos;

        Vector3 pos = transform.position;
        pos.z += GetRandomRange();
        pos.x += GetRandomRange();
        transform.position = pos;

    }

    // eden kod za menuvanje. 
    private float GetRandomRange()
    {
        return Random.Range(-teleportRange, teleportRange);
    }


    public override void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce * 0.5f);
    }

}
    