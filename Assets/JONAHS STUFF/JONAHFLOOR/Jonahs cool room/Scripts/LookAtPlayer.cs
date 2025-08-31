using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform cam; // drag your Camera here

    void LateUpdate()
    {
        if (!cam) return;

        // Get current rotation
        Vector3 euler = transform.eulerAngles;

        // Copy only Y from the camera
        euler.y = cam.eulerAngles.y;

        // Apply
        transform.rotation = Quaternion.Euler(euler);
    }
}
