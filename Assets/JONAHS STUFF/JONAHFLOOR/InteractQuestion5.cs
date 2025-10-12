using UnityEngine;

public class InteractQuestion5 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    public MeshFilter MeshFilter;
    public Mesh meshA;
    public Mesh meshB;
    public Mesh meshC;
    public Mesh meshD;
    public Mesh meshDefault;

    public GameObject Question5Selections;


    public GameObject RedX;
    public GameObject Tick;

    public AudioSource Q5;
    public GameObject Jonah;

    public GameObject AllTheJonahs;

    public GameObject Explosion2;



    void Start()
    {

        outline = gameObject.GetComponent<Outline>();
        Q5.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.Q5Selected != "NONE")
        {
            if (JR1STATICMANAGER.Q5Selected == "C"
                ||
                JR1STATICMANAGER.Q5Selected == "B"
                ||
                JR1STATICMANAGER.Q5Selected == "D")

            {
                Explosion2.SetActive(true);
                AllTheJonahs.SetActive(false);

                RedX.SetActive(true);
                Destroy(gameObject);
                Question5Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 5;
            }
            else if (JR1STATICMANAGER.Q5Selected == "A")
            {
                Explosion2.SetActive(true);

                JR1STATICMANAGER.questionsright++;
                AllTheJonahs.SetActive(false);

                Tick.SetActive(true);
                Destroy(gameObject);
                Question5Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 5;
            }


        }

        if (JR1STATICMANAGER.Q5Selected == "A")
        {
            MeshFilter.mesh = meshA;
        }
        else if (JR1STATICMANAGER.Q5Selected == "B")
        {
            MeshFilter.mesh = meshB;
        }
        else if (JR1STATICMANAGER.Q5Selected == "C")
        {
            MeshFilter.mesh = meshC;
        }
        else if (JR1STATICMANAGER.Q5Selected == "D")
        {
            MeshFilter.mesh = meshD;
        }
        else
        {
            MeshFilter.mesh = meshDefault;
        }



        if (outline.enabled == true && Input.GetKeyDown(KeyCode.E) && donethething == false)
        {
            Explosion2.SetActive(false);
            gameObject.GetComponent<Animator>().Play("GoIntoPos");
            donethething = true;
            outline.enabled = false;
            gameObject.tag = "Untagged";
            Question5Selections.SetActive(true);
            AllTheJonahs.SetActive(true);

        }

    }
}
