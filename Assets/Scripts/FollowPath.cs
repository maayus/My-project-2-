using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{

    public List<Vector3> path;
    public float speed = 10;

    private Vector3 target;
    private int currentPoint = 0;
    private bool go = true;

    void Start()
    {
        target = path[currentPoint];
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target)<0.3f)
        {
            if (currentPoint != path.Count - 1 && go == true)
            {
                if (go == true)
                {
                    target = path[++currentPoint];
                }
            }
            else if (currentPoint != 0 && go == false)
            {
                target = path[--currentPoint];
            }
            else
            {   
                if(go == true)
                {
                    go = false;
                    target = path[--currentPoint];
                }
                else
                {
                    go = true;
                    target = path[++currentPoint];
                }
            }
         
        }

        transform.LookAt(target);
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 0; i < path.Count-1; i++)
            {
                Gizmos.DrawLine(path[i], path[i+1]);
            }
    }

}
