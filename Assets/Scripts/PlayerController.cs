using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [HideInInspector] public Rigidbody2D rb;
    //[HideInInspector] public Animator animator;
    public float moveSpeed = 5;

    private void Start()
    {
        //animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Magnitude", movement.magnitude);

        if (movement.magnitude > 1)
        {
            movement = movement.normalized;
        }

        rb.MovePosition(new Vector2(transform.position.x + movement.x * moveSpeed * Time.deltaTime, transform.position.y + movement.y * moveSpeed * Time.deltaTime));
    }
}
