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
        if (JR1STATICMANAGER.questiondone == 2)
        {
            print("brih whats going on");
            Jonah.GetComponent<Animator>().Play("question 3");
        }
        if (JR1STATICMANAGER.questiondone == 3)
        {
            print("brih whats going on");
            Jonah.GetComponent<Animator>().Play("question4");
        }
        if (JR1STATICMANAGER.questiondone == 4)
        {
            print("brih whats going on");
            Jonah.GetComponent<Animator>().Play("question5");
        }
        if (JR1STATICMANAGER.questiondone == 5)
        {
            print("brih whats going on");
            Jonah.GetComponent<Animator>().Play("q5DONE");
        }
    }
}
