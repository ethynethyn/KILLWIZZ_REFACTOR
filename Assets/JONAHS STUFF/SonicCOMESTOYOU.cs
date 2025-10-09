using StarterAssets;
using UnityEditor.Rendering;
using UnityEngine;

public class SonicCOMESTOYOU : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Speed at which the object moves toward the camera.")]
    public float moveSpeed = 3f;

    [Header("Rotation Settings")]
    [Tooltip("How quickly the rotation moves toward the target rotation.")]
    public float rotationResetSpeed = 2f;

    [Tooltip("The target rotation in degrees (Euler angles).")]
    public Vector3 targetEulerRotation = new Vector3(0f, 86.374f, 0f);
    public float expandSpeed = 5f;
    public Vector3 expandedScale = new Vector3(10f, 10f, 10f);
    private Vector3 originalScale;
    private float expandProgress = 0f;
    private float timer = 2f;
    public CharacterController cc;
    private float timer2 = 2f;
    //public GameObject player;

    public GameObject black;

    private void Start()
    {
        cc.enabled = (false);
        //player.SetActive(false);
        originalScale = transform.localScale;

    }
    public void DeleteAnimator()
    {
        gameObject.GetComponent<Animator>().enabled = false;
    }
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {


            black.SetActive(true);

        
            timer2 = timer2 - Time.deltaTime;
            if ( timer2 < 0)
            {
                black.SetActive(false);

                cc.enabled = (true);

                //player.SetActive(true);
                Destroy(gameObject);
            }

        }




        Camera cam = Camera.main;
        if (cam == null) return;

        // --- Move toward the camera (XZ plane only) ---
        Vector3 targetPos = cam.transform.position;
        targetPos.y = transform.position.y; // keep current height
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPos,
            moveSpeed * Time.deltaTime
        );

        // --- Smoothly rotate toward the target rotation ---
        Quaternion targetRotation = Quaternion.Euler(targetEulerRotation);
        transform.rotation = Quaternion.Slerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * rotationResetSpeed
        );
    }
}
