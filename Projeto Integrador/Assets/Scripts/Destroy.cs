using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Enemy.enemy.velocity = 0;
            Player.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Player.player.jumpForce);
            Enemy.enemy.GetComponent<Animator>().SetBool("died", true);
            Destroy(enemy);
        }
    }
}
