// ElevatorAutoOpen.cs
using UnityEngine;

public class ElevatorAutoOpen : MonoBehaviour
{
    public Animator doorAnimator;
    public float delay = 1f;

    void Start()
    {
        if (doorAnimator)
        {
            Invoke(nameof(OpenDoors), delay);
        }
    }

    void OpenDoors()
    {
        doorAnimator.SetTrigger("Open");
    }
}
