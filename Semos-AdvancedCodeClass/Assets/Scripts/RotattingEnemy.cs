using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotattingEnemy : BlinkinEnemy
{
    

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.y += 0.01f;
        transform.eulerAngles = rotation;

    }
}
