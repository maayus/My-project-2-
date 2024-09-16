using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;

    void Update()
    {
        //var - chooses the type of variable automatically
        var x = Input.GetAxisRaw("Horizontal");
        var z = Input.GetAxisRaw("Vertical");


        //Move the player
        //new Vector3(x, 0, z).normalized - makes the player move at the same speed 
        //in all directions
        transform.position += new Vector3(x, 0, z).normalized * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("Game Over");
        }
    }
}
