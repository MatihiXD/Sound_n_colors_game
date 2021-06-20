using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public bool isJumping;
    public bool isGrounded;
    public Transform groundCheckLeft;
    public Transform groundCheckRight;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite jump;
    public Sprite idle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapArea(groundCheckLeft.position, groundCheckRight.position);
        float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        if (Input.GetAxis("Horizontal") > 0) {
            spriteRenderer.flipX = false;
        } else if (Input.GetAxis("Horizontal") < 0) {
            spriteRenderer.flipX = true;
        }
        if (Input.GetButtonDown("Jump") && isGrounded) {
            isJumping = true;
        }
        MovePlayer(translation);
    }

    //Function to call movements
    void MovePlayer(float _translation)
    {
        transform.Translate(_translation, 0, 0);
        if (isJumping == true) {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
        if (isGrounded == true) {
            spriteRenderer.sprite = idle;
        } else if (isGrounded == false) {
            spriteRenderer.sprite = jump;
        }
    }
}
