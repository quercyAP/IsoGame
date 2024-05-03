using UnityEngine;

public class IsoCharacterController : MonoBehaviour
{
    public float speed = 5.0f; // Vitesse de déplacement du personnage
    private Animator animator;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        animator = GetComponent<Animator>(); // Récupération du composant Animator
        rb = GetComponent<Rigidbody2D>(); // Récupération du composant Rigidbody2D
    }

    void Update()
    {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Animation
        animator.SetFloat("MoveX", movement.x);
        animator.SetFloat("MoveY", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}
