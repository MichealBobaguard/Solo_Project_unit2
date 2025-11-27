using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Animator anim;

    private float moveHorizontal;
    private float moveVertical;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void FixedUpdate()
    {
        // Apply movement using velocity
        rb.linearVelocity = new Vector2(moveHorizontal, moveVertical) * speed;

        // Update animation only when moving
        if (rb.linearVelocity != Vector2.zero)
        {
            anim.SetFloat("MoveX", moveHorizontal);
            anim.SetFloat("MoveY", moveVertical);
            anim.SetBool("Moving", true);
        }
        else
        {
            anim.SetBool("Moving", false);
        }

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
