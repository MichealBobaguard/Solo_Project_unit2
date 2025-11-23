using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private float moveHorizontal;
    private float moveVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        // Apply movement using velocity
        rb.linearVelocity = new Vector2(moveHorizontal, moveVertical) * speed;

    }



    void Update()
    {
        // Get input
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        // Prevent diagonal movement
        if (moveHorizontal != 0)
            moveVertical = 0;
    }


}
