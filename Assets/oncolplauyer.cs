using UnityEngine;

public class oncolplauyer : MonoBehaviour
{
    public GameObject Ele;

    private bool timercan;
    private float timer = 3f;
    private void Update()
    {
        if (timercan)
        {
            timer = timer - Time.deltaTime;
            if (timer < 0)
            {
                Ele.GetComponent<Animator>().Play("close");
            }
        }
        else
        {
            timer = 3f;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            timercan = true;
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "player")
        {
            timercan = false;

        }
    }
}
