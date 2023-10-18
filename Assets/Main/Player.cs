using UnityEngine;

public class Player : MonoBehaviour
{

    public float gravity = -40.0f;
    public float jumpForce = 20.0f;


    private float jumpVelocity = 0.0f;
    private bool onFloor = true;

    void Update()
    {
        if (Input.GetAxis("Jump") > 0.1f  && onFloor) {
            
            onFloor = false;
            jumpVelocity += jumpForce;
        }

        if (!onFloor) {
            jumpVelocity += gravity * Time.deltaTime;
            gameObject.transform.Translate(new Vector2(0.0f, jumpVelocity * Time.deltaTime));

            if (transform.position.y < -2.0f) {
                onFloor = true;
                jumpVelocity = 0.0f;
                transform.position = new Vector3(transform.position.x, -2.0f);
            }

        }

    }
}
