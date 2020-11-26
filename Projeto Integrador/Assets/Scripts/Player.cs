using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private bool isJump;
    private bool doubleJump = false;
    private Rigidbody2D rigid;
    private Animator anim;

    [SerializeField]
    private LayerMask layer;
    public static Player player;
    
    void Start()
    {
        player = this;
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float move = Input.GetAxisRaw("Horizontal") * speed*Time.deltaTime;
        transform.position += new Vector3(move, 0, 0);

        if(move > 0)
        {
            anim.SetBool("run",true);
            transform.eulerAngles = new Vector2(0, 0);
        }
        else if (move < 0)
        {
            anim.SetBool("run", true);
            transform.eulerAngles = new Vector2(0, 180);
        }
        else if (move == 0)
        {
            anim.SetBool("run", false);
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            //rigid.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
            doubleJump = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, jumpForce);
            doubleJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.gameObject.layer == 8 || collision.gameObject.CompareTag("Platform"))
        {
            isJump = false;
            anim.SetBool("jump", false);
        }

        if (collision.gameObject.layer == 9)
        {
            Player_controller.instance.gameOver.SetActive(true);
            gameObject.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.CompareTag("Platform"))
        {
            isJump = true;
            anim.SetBool("jump",true);
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.parent = null;
        }
    }
}
