using UnityEngine;

public class MoveGoblinNow : MonoBehaviour
{
    public Animator animator;
    public GameObject goblin;

    public GameObject exampleTrigger;
    public GameObject NextDialogueTrigger;

    public void MoveToSide()
    {
        animator.Play("gotoleft");
        goblin.GetComponent<Animator>().Play("bow");
        exampleTrigger.SetActive(false);
        NextDialogueTrigger.SetActive(true);

    }
    public void TalkedAfterBow()
    {
        goblin.GetComponent<Animator>().SetBool("talkedafterbow", true);
    }

}
