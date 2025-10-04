using UnityEngine;

public class StartQuestion2 : MonoBehaviour
{
    public GameObject Jonah;
    public void StartQNext()
    {
        print(JR1STATICMANAGER.questiondone);
        if (JR1STATICMANAGER.questiondone == 1)
        {
            print("brih whats going on");
            Jonah.GetComponent<Animator>().Play("question2");
        }
    }
}
