using UnityEngine;
using TMPro;

public class ShowTMPOnTrigger : MonoBehaviour
{
    [Header("Assign the TextMeshPro object here")]
    public TextMeshProUGUI messageText;

    [Header("Optional Settings")]
    public string playerTag = "Player"; // Tag to detect
    public bool hideOnStart = true;     // Hide at the beginning

    private void Start()
    {
        if (messageText != null && hideOnStart)
        {
            messageText.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (messageText != null)
                messageText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            if (messageText != null)
            {
                Destroy(messageText.gameObject); // completely remove it from the scene
            }
        }
    }
}
