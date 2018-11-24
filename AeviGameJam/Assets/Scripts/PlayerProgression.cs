using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgression : MonoBehaviour {
    private GameHandler GM;

    public GameObject FadingPanel;

    // Use this for initialization
    void Start () {
        FadingPanel.GetComponent<Animator>().SetTrigger("FadeIn");
        GM = GameObject.FindGameObjectWithTag("GameHandler").GetComponent<GameHandler>();
        if (GM.LastCheckPointPos != Vector2.zero)
        {
            this.transform.position = GM.LastCheckPointPos;
        }
        Camera.main.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.gameObject.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
