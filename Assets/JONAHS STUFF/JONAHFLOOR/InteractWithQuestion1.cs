using UnityEngine;

public class InteractWithQuestion1 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    void Start()
    {
        outline = gameObject.GetComponent<Outline>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (outline.enabled == true && Input.GetKeyDown(KeyCode.E) && donethething == false)
        {
            gameObject.GetComponent<Animator>().Play("GoIntoPos");
            donethething = true;
            outline.enabled = false;
            gameObject.tag = "Untagged";
        }

    }
}
