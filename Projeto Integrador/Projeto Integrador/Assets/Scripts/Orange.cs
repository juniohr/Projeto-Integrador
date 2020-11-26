using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public GameObject obj;
    public SpriteRenderer spriteR;
    public CircleCollider2D cirCol;

    public void Start()
    {
        obj.SetActive(false);
        spriteR = GetComponent<SpriteRenderer>();
        cirCol = GetComponent<CircleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteR.enabled = false;
            cirCol.enabled = false;
            obj.SetActive (true);
            Player_controller.instance.totalScore += 10;
            Destroy(gameObject, 0.3f);
        }
    }
}
