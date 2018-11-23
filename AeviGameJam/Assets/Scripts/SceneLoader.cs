using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour {

    public static SceneLoader Instance { get; set; }
    public GameObject LoadingScreenUI;
    public bool isLoading = false;
    public Animator loadinganim;

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
        StartCoroutine(LoadAsync(SceneIndex,save));
    }

    IEnumerator LoadAsync (int SceneIndex, SaveData save)
    {
        isLoading = true;
        if(SceneIndex == 1)
        {
            Debug.Log("test");
        }

        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        LoadingScreenUI.SetActive(true);

        while (!operation.isDone)
        {

            yield return null;
        }
        yield return new WaitForSeconds(3);
        loadinganim.SetTrigger("Finished");
        yield return new WaitForSeconds(1);
        LoadingScreenUI.SetActive(false);


        isLoading = false;


    }
}
