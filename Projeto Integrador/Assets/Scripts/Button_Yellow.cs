using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Yellow : MonoBehaviour
{
    public Animator anim;
    public BoxCollider2D col;
    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Lever.lever.button == 3)
        {
            anim.SetBool("press", false);
            col.enabled = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            col.enabled = false;
            anim.SetBool("press", true);
            Lever.lever.button++;
        }
        if (Lever.lever.button == 3)
        {
            anim.SetBool("press", false);
            col.enabled = true;
        }
    }
}
