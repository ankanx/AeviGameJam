using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public float timeBetweenAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemy;
    public int damage;
    public InputScript input;

	// Use this for initialization
	void Start () {
        input = GetComponent<InputScript>();
	}
	
	// Update is called once per frame
	void Update () {

        if(input.horizvect < 0)
        {
            attackPos.position = new Vector2(gameObject.transform.position.x  - 0.3f , gameObject.transform.position.y);
        }
        else if(input.horizvect > 0)
        {
            attackPos.position = new Vector2(gameObject.transform.position.x + 0.3f, gameObject.transform.position.y);
        }
        
        if(input.verticalvect < 0)
        {
            attackPos.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.3f);
        }
        else if(input.verticalvect > 0)
        {
            attackPos.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.3f);
        }

		if(timeBetweenAttack <= 0)
        {
            if (Input.GetButtonDown("Submit"))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position,attackRange, whatIsEnemy);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
                timeBetweenAttack = startTimeBtwAttack;
            }

        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
	}

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position,attackRange);
    }
}
