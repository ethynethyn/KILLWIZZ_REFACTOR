using UnityEngine;

public class PlayRoar : MonoBehaviour
{

    public AudioSource source;

    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            source.Play();
        Debug.Log("Played");
    }
}
