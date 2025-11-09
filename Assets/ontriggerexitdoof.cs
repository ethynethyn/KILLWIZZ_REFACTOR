using UnityEngine;

public class ontriggerexitdoof : MonoBehaviour
{
    public GameObject samface;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            samface.GetComponent<Animator>().Play("New State");
        }
    }
}
