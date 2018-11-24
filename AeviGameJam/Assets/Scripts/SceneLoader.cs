using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour {

    public static SceneLoader Instance { get; set; }
    public GameObject LoadingScreenUI;
    public bool isLoading = false;
    public Animator loadinganim;
    public TextMeshProUGUI loadingText;
    public Animator fadepanel;
    public Image animimg;
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
        fadepanel.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        animimg.enabled = true;
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

        fadepanel.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1);
        loadinganim.SetTrigger("Done");
        animimg.enabled = false;
        LoadingScreenUI.GetComponent<Canvas>().enabled = false;
        isLoading = false;


    }
}
