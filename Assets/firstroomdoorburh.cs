using UnityEngine;
using UnityEngine.SceneManagement;


public class firstroomdoorburh : MonoBehaviour
{
    private Outline outline;
    private void Start()
    {
        outline = gameObject.GetComponent<Outline>();
    }
    void Update()
    {


        if (JR1STATICMANAGER.FirstDoor)
        {
            outline.enabled = true;
        }
        else
        {
            outline.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.FirstDoor)
        {
            SceneManager.LoadScene("FirstScene");
        }
    }
}
