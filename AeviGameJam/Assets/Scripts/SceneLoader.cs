using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class SceneLoader : MonoBehaviour {

    public static SceneLoader Instance { get; set; }
    public GameObject LoadingScreenUI;
    public bool isLoading = false;
    public Animator loadinganim;
    public TextMeshProUGUI loadingText;

    private void Start()
    {
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

    public void LoadScene (int SceneIndex,SaveData save)
    {
        Time.timeScale = 1f;
        LoadingScreenUI.GetComponent<Canvas>().enabled = true;
        StartCoroutine(LoadAsync(SceneIndex,save));
    }

    IEnumerator LoadAsync (int SceneIndex, SaveData save)
    {
        isLoading = true;
        loadingText.text = "Loading";
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        while (!operation.isDone)
        {
            loadingText.text = loadingText.text + ".";
            yield return null;
        }
        yield return new WaitForSeconds(3);
        loadinganim.SetTrigger("Finished");
        loadingText.text = "";
        yield return new WaitForSeconds(1);
        loadinganim.SetTrigger("Done");
        LoadingScreenUI.GetComponent<Canvas>().enabled = false;
        isLoading = false;


    }
}
