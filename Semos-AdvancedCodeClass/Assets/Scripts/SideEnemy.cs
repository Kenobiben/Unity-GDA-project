using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideEnemy : Enemy
{
    
    // ovde da napravite overide na fukncija move i za side enemy da implementirate logika na dvizenje od sprotivna strana

    public override void Move()

    {
        base.Move(); // call base move  go dvizi pravo od Enemy

        // logika za dvizewe vo levo - smeneta od Enemy 
        // ovoj child karakter odi pravo i levo
        Vector3 position = transform.position;
        position.x -= speed * Time.deltaTime;
        transform.position = position;
    }



} 
