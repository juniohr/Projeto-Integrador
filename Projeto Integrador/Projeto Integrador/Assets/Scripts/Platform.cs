using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    private float a;
    public float velocity, distance;
    void Start()
    {
        a = transform.position.x;
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(velocity * Time.fixedDeltaTime, 0, 0);
        if (transform.position.x >= a + distance)
        {
            a = transform.position.x;
            velocity = -velocity;
        }
        else if (transform.position.x <= a - distance)
        {
            a = transform.position.x;
            velocity = Mathf.Abs(velocity);
        }
    }
}
