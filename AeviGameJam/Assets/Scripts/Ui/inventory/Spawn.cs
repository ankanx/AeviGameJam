using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject item;
    private Transform Player;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	

    public void SpawnDroppedItem()
    {
        Vector2 playerpos = new Vector2(Player.transform.position.x, Player.transform.position.y + 1f);
        Instantiate(item, playerpos, Quaternion.identity);
    }
}
