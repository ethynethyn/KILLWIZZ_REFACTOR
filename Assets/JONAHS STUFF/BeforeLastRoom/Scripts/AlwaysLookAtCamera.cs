using UnityEngine;

public class AlwaysLookAtCamera : MonoBehaviour
{
    private Transform cam;
    public AudioSource JonahTalking;
    public ChildFuctionHandler ChildFH;
    public GameObject GoblinTrigger;
    private bool played;

    void Start()
    {
        ChildFH.ForceOpenDo();
        JonahTalking.Play();
        cam = Camera.main.transform;
    }

    void Update()
    {
        if (JonahTalking.isPlaying)
        {
            played = true;
        }
        if (played)
        {
            if (!JonahTalking.isPlaying)
            {
                played = false;
                ChildFH.ForceCloseDo();
                GoblinTrigger.SetActive(true);

            }
        }


        if (cam == null) return;

        Vector3 lookPos = cam.position;
        lookPos.y = transform.position.y; // keep same Y
        transform.LookAt(lookPos);
    }
}
