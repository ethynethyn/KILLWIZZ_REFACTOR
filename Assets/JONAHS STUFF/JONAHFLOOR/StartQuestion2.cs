using UnityEngine;

public class StartQuestion2 : MonoBehaviour
{
    public GameObject Jonah;
    public void StartQNext()
    {
        if (JR1STATICMANAGER.questiondone == 1)
        {
            Jonah.GetComponent<Animator>().Play("question2");
        }
    }
}
