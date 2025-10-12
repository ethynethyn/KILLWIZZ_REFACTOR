using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public void SetTagToDoor1()
    {
        gameObject.tag = "Door1";
    }
    void Update()
    {
        if (JR1STATICMANAGER.MainRoomdoor1)
        {
            gameObject.GetComponent<Outline>().enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("JonahFloorScene");
            }
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;

        }
    }
}
