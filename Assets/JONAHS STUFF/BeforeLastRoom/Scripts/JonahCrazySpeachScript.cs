using UnityEngine;

public class JonahCrazySpeachScript : MonoBehaviour
{
    
    [Header("Approach Settings")]
    public float moveSpeed = 3f;
    public float stopDistance = 1.5f; // distance in front of camera
    public float rotationSpeed = 5f;

    [Header("References")]
    public Transform cameraTransform; // usually main camera
    public MonoBehaviour lookAtScriptToEnable; // script to enable after reaching

    private bool isMoving = true;

    void Start()
    {
        if (cameraTransform == null)
            cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (!isMoving) return;

        // Get target position in front of camera, same Y as this object
        Vector3 targetPos = cameraTransform.position + cameraTransform.forward * stopDistance;
        targetPos.y = transform.position.y;

        // Move toward target
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        // Smoothly rotate to face the camera horizontally
        Vector3 lookPos = cameraTransform.position;
        lookPos.y = transform.position.y;
        Quaternion targetRot = Quaternion.LookRotation(lookPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);

        // Check if reached
        if (Vector3.Distance(transform.position, targetPos) < 0.05f)
        {
            isMoving = false;

            if (lookAtScriptToEnable != null)
                lookAtScriptToEnable.enabled = true;
                gameObject.GetComponent<JonahCrazySpeachScript>().enabled = false; 
        }
    }
}