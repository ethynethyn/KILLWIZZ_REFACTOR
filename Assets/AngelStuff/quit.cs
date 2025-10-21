using UnityEngine;

public class quit : MonoBehaviour
{
    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        
    }
}
