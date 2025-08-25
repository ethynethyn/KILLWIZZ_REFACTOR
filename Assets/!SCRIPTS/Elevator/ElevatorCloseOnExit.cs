using UnityEngine;

public class ElevatorDoorCloseOnExit : MonoBehaviour
{
    public Animator doorAnimator;
    public string closeTriggerName = "Close"; // Name of the close trigger in Animator

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger(closeTriggerName);
            }
        }
    }
}
