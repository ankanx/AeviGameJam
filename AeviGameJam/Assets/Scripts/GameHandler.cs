using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour {

    public static GameHandler Instance { get; set; }
    public GameObject Player;
    public GameObject FadingPanel;

    public Vector2 LastCheckPointPos;
    // Use this for initialization
    void Start () {

        Player = GameObject.FindGameObjectWithTag("Player");

        DontDestroyOnLoad(gameObject);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }



	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Fix
            FadingPanel = GameObject.FindGameObjectWithTag("FadePanelWorld").gameObject;
            FadingPanel.GetComponent<Animator>().SetTrigger("FadeOut");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
	}
}
