using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    private GameHandler GM;
    bool isTriggered = false;

    private void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isTriggered)
        {
            GM.LastCheckPointPos = transform.position;
            //GetComponent<SpriteRenderer>().color = new Color(255,0,0,255);
            GetComponent<Animator>().SetTrigger("ColorChange");
            isTriggered = true;
        }
    }
}
