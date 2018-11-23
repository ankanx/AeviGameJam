using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject PlayerMenu;

    public GameObject currentlySelected;


    // Update is called once per frame
    void Update()
    {

        if (EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject != currentlySelected)
        {
            currentlySelected = EventSystem.current.currentSelectedGameObject;
        }
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            EventSystem.current.SetSelectedGameObject(currentlySelected);
        }

        // fix so that its controlled by the menu instead?
        if (Input.GetButtonDown("J1START"))
        {
            if (GameIsPaused)
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
        PlayerMenu.SetActive(false);
        PlayerMenu.transform.Find("Options_Menu").gameObject.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PlayerMenu.SetActive(true);
        PlayerMenu.transform.Find("PauseMenu").gameObject.SetActive(true);
        Time.timeScale = 0f;
        PlayerMenu.transform.Find("PauseMenu").transform.Find("Return Button").GetComponent<Button>().Select();
        PlayerMenu.transform.Find("PauseMenu").transform.Find("Return Button").GetComponent<Button>().OnSelect(null);
        GameIsPaused = true;
    }
}
