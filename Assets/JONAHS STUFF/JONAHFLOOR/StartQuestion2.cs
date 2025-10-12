using UnityEngine;

public class StartQuestion2 : MonoBehaviour
{
    public GameObject Jonah;
    public AudioSource q2;
    public AudioSource q3;
    public AudioSource q4;
    public AudioSource q5;
    public void StartQNext()
    {
        
        if (q2.isPlaying)
        {
            q2.Stop();
        }

        if (q3.isPlaying)
        {
            q3.Stop();
        }
        if (q4.isPlaying)
        {
            q4.Stop();
        }
        if (q5.isPlaying)
        {
            q5.Stop();
        }



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
