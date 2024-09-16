using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    public float speed = 5;
    public float height = 3;

    void Update()
    {
        var y = Mathf.Sin(Time.time*speed)*height;
        y = Mathf.Abs(y);

        var x = transform.position.x;
        var z = transform.position.z;

        transform.position = new Vector3(x, y, z);
    }
}
