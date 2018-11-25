using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject item;

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            Debug.Log(inventory.slots.Length);
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                
                if (inventory.isFull[i] == false)
                {
                    GetComponent<ParticleSystem>().Play();
                    Debug.Log("pick up item " + inventory.isFull[i] + " " + inventory.slots[i].transform.childCount);
                    // add item
                    inventory.isFull[i] = true;
                    Instantiate(item,inventory.slots[i].transform,false);
                    GetComponent<SpriteRenderer>().enabled = false;
                    StartCoroutine("Recycledestroy");
                    break;
                }
            }
        }
    }


    IEnumerator Recycledestroy()
    {
         yield return new WaitForSeconds(0.5f);
         Destroy(gameObject);
        
    }
}
