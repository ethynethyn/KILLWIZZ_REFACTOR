using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScriptFinalRoom : MonoBehaviour
{
    private Outline outline;
    private void Start()
    {
        outline = gameObject.GetComponent<Outline>();
    }
    private void Update()
    {

        if (outline.isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("JONAHROOMFINAL");
            }
        }
    }
}
