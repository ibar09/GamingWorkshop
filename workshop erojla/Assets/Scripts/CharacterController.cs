using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Animator animator;
    public float jump_power;
    public LayerMask groundLayer;
    public Transform groundCheker;
    public float radius = 0.005f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        animator.SetBool("isJumping", !groundCheck());
        animator.SetFloat("yVelocity", rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && groundCheck())
        {
            rb.velocity = Vector2.up * jump_power;
        }
    }
    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, rb.velocity.y);
        rb.velocity = direction;
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.localScale = new Vector3(Input.GetAxisRaw("Horizontal"), 1, 1);
        }

    }

    public bool groundCheck()
    {
        return Physics2D.OverlapCircle(groundCheker.position, radius, groundLayer);
    }


}
