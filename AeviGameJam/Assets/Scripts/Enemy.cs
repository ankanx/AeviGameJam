using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health;
    public float speed;

    Transform target;
    Vector2 movementVector;
    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        target = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (target.CompareTag("Player"))
        {
            anim.SetBool("Iswalking", true);
            movementVector = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            transform.position = movementVector;
            /*if (movementVector.x > 0.5)
            {
                anim.SetFloat("X", 1);
            }else if(movementVector.x < -0.5)
            {
                anim.SetFloat("X", -1);
            }
            if (movementVector.y > 0)
            {
                anim.SetFloat("Y", 1);
            }
            else if (movementVector.y < 0)
            {
                anim.SetFloat("Y", -1);
            }*/
            anim.SetFloat("X", movementVector.x);
            anim.SetFloat("Y", movementVector.y);

        }
        else
        {
            anim.SetBool("Iswalking", false);
        }
	}

    public void TakeDamage(int Damage)
    {
        if(health <= 0)
        {
            StartCoroutine("Die");
        }
        else
        {
            health -= Damage;
            anim.SetTrigger("Damage");
        }

    }

    IEnumerator Die()
    {
        anim.SetTrigger("Die");
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            target = collision.gameObject.transform;
        }
    }
}
