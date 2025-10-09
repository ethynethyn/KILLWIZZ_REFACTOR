using UnityEngine;

public class FaceThePlayer : MonoBehaviour
{
    [Tooltip("How far to rotate to the left (in degrees) relative to the camera facing direction.")]
    public float leftOffsetDegrees = 15f;

    [Tooltip("Whether to ignore camera tilt and only rotate on the Y axis.")]
    public bool onlyRotateOnY = true;

    void LateUpdate()
    {

        if (StaticSONIC.SonicShoot)
        {
            Camera cam = Camera.main;
            if (!cam) return;

            Vector3 direction = cam.transform.position - transform.position;

            if (onlyRotateOnY)
                direction.y = 0f; // keep upright

            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion lookRotation = Quaternion.LookRotation(direction.normalized, Vector3.up);
                // Apply the left offset
                Quaternion offsetRotation = Quaternion.Euler(0f, -leftOffsetDegrees, 0f);
                transform.rotation = lookRotation * offsetRotation;
            }
        }

    }
}