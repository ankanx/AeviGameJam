using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class InputScript : MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;

    public float moveMultiplier = 1.5f;
    public float maxSpeed = 5f;
    public GameObject menu;

    private Animator animator;
    private Rigidbody2D rigidbody2d;

    public AudioClip audio_jump;
    public AudioClip audio_walk;
    public AudioSource audio_source;
    public float horizvect;
    public float verticalvect;


    void Start()
    {

        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.gravityScale = 0;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

        Vector2 movementVector = new Vector2(h , v);

        
        if(movementVector != Vector2.zero && rigidbody2d.bodyType == RigidbodyType2D.Dynamic)
        {
            animator.SetBool("IsWalking", true);
            animator.SetFloat("InputX", movementVector.x);
            animator.SetFloat("InputY", movementVector.y);
            horizvect = h;
            verticalvect = v;
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        movementVector = movementVector * moveMultiplier;
        rigidbody2d.MovePosition(rigidbody2d.position + movementVector * Time.deltaTime);

    }
}