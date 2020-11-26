using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Animator[] anim;
    public GameObject uiLever;
    public BoxCollider2D[] col;
    public static Lever lever;
    public byte button;
    public string fase;
    public GameObject panel;
    void Start()
    {
        lever = this;
        anim[0] = GetComponent<Animator>();
        anim[1].SetBool("open_close", false);
        anim[2].SetBool("open_close", false);
    }

    void Update()
    {
        if (fase == "fase2" && button == 2)
        {
            anim[3].SetBool("on",true);
        }
        if (fase == "fase3" && button == 4)
        {
            anim[3].SetBool("on",true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uiLever.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uiLever.SetActive(false);
        }
    }

    public void Left()
    {
        
            col[1].enabled = false;
            col[0].enabled = true;
            anim[0].SetBool("right", false);
            anim[0].SetBool("left", true);
            anim[1].SetBool("open_close", false);
            anim[2].SetBool("open_close", true);
        
       
    }

    public void Right()
    {
        if (fase =="fase1")
        {
            col[1].enabled = true;
            col[0].enabled = false;
            anim[0].SetBool("left", false);
            anim[0].SetBool("right", true);
            anim[1].SetBool("open_close", true);
            anim[2].SetBool("open_close", false);
        }
        else if (fase == "fase2" && button == 2)
        {
            col[1].enabled = true;
            col[0].enabled = false;
            anim[0].SetBool("left", false);
            anim[0].SetBool("right", true);
            anim[1].SetBool("open_close", true);
            anim[2].SetBool("open_close", false);
        }
        else if (fase == "fase3" && button == 4)
        {
            col[1].enabled = true;
            col[0].enabled = false;
            anim[0].SetBool("left", false);
            anim[0].SetBool("right", true);
            anim[1].SetBool("open_close", true);
            anim[2].SetBool("open_close", false);
        }
        else
        {
            panel.SetActive(true);
            Invoke("PanelOn",2);
        }
    }
    void PanelOn()
    {
        panel.SetActive(false);
    }
}
