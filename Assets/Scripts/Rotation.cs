using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        //speed * Time.deltaTime makes the rotation frame rate independent
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
