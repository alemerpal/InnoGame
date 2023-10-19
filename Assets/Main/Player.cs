using UnityEngine;

public class Player : MonoBehaviour
{

    public float gravity = -40.0f;
    public float jumpForce = 20.0f;

    private bool onFloor = true;

    private Animator animator;
    private Rigidbody2D rigidbody2D;


    private void Awake() {
        animator = gameObject.GetComponentInChildren<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (Input.GetAxis("Jump") > 0.1f && onFloor) {
            
            onFloor = false;

            animator.Play("Jump");
            Invoke("Jump", 0.1f);            

        }

        if (!onFloor) {
            rigidbody2D.velocity += Vector2.up * gravity * Time.deltaTime;
            if (rigidbody2D.velocity.y < 0.0f) {
                animator.Play("Fall");
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Floor") {
            onFloor = true;
            rigidbody2D.velocity = Vector2.zero;
            animator.Play("Run");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Obstacle") {
            GameManager.gameManager.gameOver();
        }
    }

    void Jump() {
        rigidbody2D.velocity = Vector2.up * jumpForce;
        animator.Play("Air");
    }
}
