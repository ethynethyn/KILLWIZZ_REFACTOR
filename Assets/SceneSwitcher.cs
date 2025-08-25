using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AsyncSceneLoader : MonoBehaviour
{
    [Header("Scene Settings")]
    [Tooltip("Enter the name of the scene you want to load")]
    public string sceneToLoad;

    [Tooltip("Show a loading screen while the scene loads")]
    public GameObject loadingScreen;

    public void LoadSceneAsyncButton()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            StartCoroutine(LoadSceneAsync());
        }
        else
        {
            Debug.LogWarning("No scene name set in AsyncSceneLoader!");
        }
    }

    private IEnumerator LoadSceneAsync()
    {
        if (loadingScreen != null)
            loadingScreen.SetActive(true); // optional

        // Begin async loading, but don't switch yet
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);
        asyncLoad.allowSceneActivation = false;

        // Wait until the scene is almost ready
        while (!asyncLoad.isDone)
        {
            // Scene loads in the background while your music keeps playing
            if (asyncLoad.progress >= 0.9f)
            {
                // When fully loaded, activate the scene
                asyncLoad.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
