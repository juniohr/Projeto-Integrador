using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject enemy;
    public Enemy inimigo;

    void Start()
    {
        inimigo = GetComponentInParent<Enemy>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inimigo.velocity = 0;
            Player.player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, Player.player.jumpForce);
            //inimigo.GetComponent<Animator>().SetBool("died", true);
            Destroy(enemy);
        }
    }
}
