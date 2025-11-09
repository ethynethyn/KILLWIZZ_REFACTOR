using UnityEngine;

public class chestscriptminecraft : MonoBehaviour
{
    private bool donethething;
    private Outline chestOutline;
    public Animator animator;
    private void Start()
    {
        chestOutline = GetComponent<Outline>();
    }
    void Update()
    {

        if (JR1STATICMANAGER.Chest)
        {
            chestOutline.enabled = true;
        }
        else
        {
           chestOutline.enabled = false;
        }


        if (JR1STATICMANAGER.Chest && Input.GetKeyDown(KeyCode.E) && donethething == false)
        {
            Destroy(chestOutline);
            donethething = true;
            animator.Play("chestOpen");
        }
    }
}
