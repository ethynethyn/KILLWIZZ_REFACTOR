using UnityEngine;
using UnityEngine.SceneManagement;

public class deactiveagameoBjectelevator : MonoBehaviour
{
    public GameObject NOleaveing;
    public void ActivateGameObject()
    {
        NOleaveing.SetActive(true);
    }
    public void GoUptotheDoof()
    {
        SceneManager.LoadScene("DoofInside");
    }
}
