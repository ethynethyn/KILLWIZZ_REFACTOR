using UnityEngine;

public class BruhRedXScript : MonoBehaviour
{
    public AudioSource WrongSound;
    public void disableMe()
    {
        gameObject.SetActive(false);
    }
    public void PlayErrorSound()
    {
        WrongSound.Play();
    }
}
