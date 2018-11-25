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


    void Start()
    {

        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.gravityScale = 0;
    }


    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetButtonDown("Cancel") && menu.transform.localScale != new Vector3(1, 1, 1))
        {
            menu.transform.localScale = new Vector3(1, 1,1);
        }
        else if(Input.GetButtonDown("Cancel") && menu.transform.localScale != new Vector3(0, 0, 0))
        {
            menu.transform.localScale = new Vector3(0, 0,0);
        }
        */
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

        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
        /*
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("some");
            GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().AddItem("sword");
        } */



        //animator.SetFloat("Speed", Mathf.Abs(h));
        /*
        if ((Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)  && grounded)
          {
          rb2d.velocity = new Vector2(0, 0);
          
        }*/
        movementVector = movementVector * moveMultiplier;
        rigidbody2d.MovePosition(rigidbody2d.position + movementVector * Time.deltaTime);

    }
}