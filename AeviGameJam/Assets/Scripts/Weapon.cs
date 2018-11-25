using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float offset;

    public GameObject projectile;
    public Transform shotPoint;

    public float timebetween;
    public float starttime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(timebetween <= 0){
            Instantiate(projectile, transform.position, transform.rotation);
            timebetween = Random.Range(0.5f,2f);

        }
        else
        {
            timebetween -= Time.deltaTime;
        }
	}
}
