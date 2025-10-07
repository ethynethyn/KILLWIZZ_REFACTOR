using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
    public GameObject interactionImage; // Drag your UI Image here in the Inspector
    public NPCConversation myConversation;

    private bool playerInTrigger;

    public void Start()
    {
        if (interactionImage != null)
            interactionImage.SetActive(false);
    }

    public void Update()
    {
        if (playerInTrigger &&
            ConversationManager.Instance != null &&
            !ConversationManager.Instance.IsConversationActive)
        {
                
            if (Input.GetKeyDown(KeyCode.E))
            {
                ConversationManager.Instance.StartConversation(myConversation);
                interactionImage.SetActive(false);
            }
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
            Debug.Log(this.gameObject.name);
            interactionImage.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            playerInTrigger = false;

            if (ConversationManager.Instance != null &&
                ConversationManager.Instance.IsConversationActive)
            {
                ConversationManager.Instance.EndConversation();
            }

            if (interactionImage != null)
                interactionImage.SetActive(false);
        }
    }
}
