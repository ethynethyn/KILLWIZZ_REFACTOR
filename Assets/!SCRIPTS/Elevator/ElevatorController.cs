using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ElevatorController : MonoBehaviour
{
    public Camera playerCamera;
    public float raycastDistance = 3f;
    public string panelTag = "ElevatorPanel";
    public string nextSceneName;

    public Animator elevatorDoorAnimator; // Animator for doors (with "Open" and "Close" triggers)
    public float doorCloseDelay = 1.5f; // Delay before loading after doors close
    public float doorOpenDelay = 1.5f; // Delay after scene load before doors open

    private bool isTransitioning = false;

    void Update()
    {
        if (isTransitioning) return;

        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, raycastDistance))
        {
            if (hit.collider.CompareTag(panelTag) && Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(LoadNextSceneSequence());
            }
        }
    }

    IEnumerator LoadNextSceneSequence()
    {
        isTransitioning = true;

        // 1. Close Elevator Doors
        if (elevatorDoorAnimator)
        {
            elevatorDoorAnimator.SetTrigger("Close");
        }

        // 2. Wait for doors to close
        yield return new WaitForSeconds(doorCloseDelay);

        // 3. Start loading next scene asynchronously
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneName);
        asyncLoad.allowSceneActivation = false;

        while (asyncLoad.progress < 0.9f)
        {
            yield return null;
        }

        // 4. Activate scene switch
        asyncLoad.allowSceneActivation = true;
    }
}
