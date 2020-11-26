using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUP : MonoBehaviour
{
    private float a;
    public float velocity, distance;
    void Start()
    {
        a = transform.position.y;
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(0, velocity * Time.fixedDeltaTime, 0);
        if (transform.position.y >= a + distance)
        {
            a = transform.position.y;
            velocity = -velocity;
        }
        else if (transform.position.y <= a - distance)
        {
            a = transform.position.y;
            velocity = Mathf.Abs(velocity);
        }
    }
}
