using UnityEngine;

public class ChangeToIdle : MonoBehaviour
{
    public GameObject Goblin;
    public GameObject GoblinController;
    public void ChangetoIdle()
    {
        Goblin.GetComponent<Animator>().Play("idle");
    }
    public void ChangetoTalking()
    {
        Goblin.GetComponent<Animator>().Play("talking");
    }
    public void ChangetoRun()
    {
        Goblin.GetComponent<Animator>().Play("walking");
    }
    public void gotowall()
    {
        print("blah");
        GoblinController.GetComponent<Animator>().Play("GoToWall");
    }
}
