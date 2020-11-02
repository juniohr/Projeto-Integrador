using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Enemy : MonoBehaviour
{
    public int velocity = 1;
    public LayerMask layer;
    public static Enemy enemy;
    void Start()
    {
        enemy = this;
    }

    void FixedUpdate()
    {
        Run();
    }

    public void Run()
    {  
        transform.position += new Vector3(velocity * Time.fixedDeltaTime, 0, 0);

        if (Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.right,1, layer))
        {
            transform.eulerAngles = new Vector2(0, 180);
            velocity = -1;
        }

        else if (Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.left, 1, layer))
        {
            transform.eulerAngles = new Vector2(0,0);
            velocity = 1;
        }
        //Debug.DrawRay(new Vector2(transform.position.x,transform.position.y), Vector2.right, Color.red);
    }
}


