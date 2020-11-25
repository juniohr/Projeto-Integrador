using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Red : MonoBehaviour
{
    public Animator anim;
    public BoxCollider2D col;
    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            col.enabled = false;
            anim.SetBool("press", true);
            Lever.lever.button++;
        }
    }
}
