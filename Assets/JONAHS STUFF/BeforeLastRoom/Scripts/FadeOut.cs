using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    

    public void ChangeSceneBack()
    {
        SceneManager.LoadScene("B42");
    }
}
