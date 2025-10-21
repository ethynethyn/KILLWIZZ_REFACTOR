using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public string scene;
    public bool isInTrigger = false;
    public GameObject interactionText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isInTrigger == true)
        {
            loadLevel();
        }
    }


    // Update is called once per frame
    public void loadLevel()
    {
        SceneManager.LoadScene(scene);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.SetActive(true);
            isInTrigger = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.SetActive(false);
            isInTrigger = false;
        }
    }
}
