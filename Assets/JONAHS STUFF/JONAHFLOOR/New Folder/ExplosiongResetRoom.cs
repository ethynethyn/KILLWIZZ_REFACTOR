using UnityEngine;
using UnityEngine.SceneManagement;


public class ExplosiongResetRoom : MonoBehaviour
{
    public void ResetRoom()
    {
        if (gameObject.name == "Sonic1")
        {
            SceneManager.LoadScene("sonic1");
        }
        if (gameObject.name == "Jonah1")
        {
            SceneManager.LoadScene("sonic1");
        }
    }
}
