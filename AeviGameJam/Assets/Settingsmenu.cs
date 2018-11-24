using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settingsmenu : MonoBehaviour {

    public static bool isPaused = false;
    public Canvas Canvas;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        Canvas.enabled = false;
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        Canvas.enabled = true;
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void SetVolume (float volume)
    {
        Debug.Log("v");
    }
}
