﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Blue : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player_controller.instance.keyB = 1;
            Destroy(gameObject);
        }
    }
}
