using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ChangeSceneAfterActive : MonoBehaviour
{
    [Header("Scene Settings")]
    [Tooltip("The name of the scene to load.")]
    public string sceneName;

    [Tooltip("How long (in seconds) to wait before starting the fade.")]
    public float delayBeforeFade = 3f;

    [Header("Fade Settings")]
    [Tooltip("How long the fade to black should take.")]
    public float fadeDuration = 1.5f;

    [Tooltip("The black Image UI element used for fading.")]
    public Image fadeImage;

    private bool hasStarted = false;

    private void OnEnable()
    {
        if (!hasStarted)
        {
            hasStarted = true;
            StartCoroutine(FadeAndChangeScene());
        }
    }

    private IEnumerator FadeAndChangeScene()
    {
        // Wait before fade begins
        yield return new WaitForSeconds(delayBeforeFade);

        if (fadeImage == null)
        {
            Debug.LogWarning("No fade image assigned in ChangeSceneWithFade.");
            yield break;
        }

        // Ensure the image is active and visible
        fadeImage.gameObject.SetActive(true);
        Color color = fadeImage.color;

        float t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            color.a = Mathf.Lerp(0f, 1f, t / fadeDuration);
            fadeImage.color = color;
            yield return null;
        }

        // Ensure it’s fully black
        color.a = 1f;
        fadeImage.color = color;

        // Load new scene
        SceneManager.LoadScene(sceneName);
    }
}
