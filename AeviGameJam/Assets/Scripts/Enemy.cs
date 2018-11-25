using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health;
    public float speed;

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
		 //
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
}
