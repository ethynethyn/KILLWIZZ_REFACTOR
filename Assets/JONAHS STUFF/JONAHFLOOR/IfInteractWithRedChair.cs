using UnityEngine;

public class IfInteractWithRedChair : MonoBehaviour
{

    public Animator anim;

    public GameObject Player;
    public GameObject putplayerpos;

    private Outline outline;
    private bool sat;
    void Start()
    {
        outline = gameObject.GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (outline.enabled == true && Input.GetKeyDown(KeyCode.E) && sat == false)
        {
            Player.transform.position = putplayerpos.transform.position;
            Player.GetComponent<CharacterController>().enabled = false;
            sat = true;
            gameObject.tag = "Untagged";
            anim.Play("HAAHHAAHAHAH");
        }
    }
}
