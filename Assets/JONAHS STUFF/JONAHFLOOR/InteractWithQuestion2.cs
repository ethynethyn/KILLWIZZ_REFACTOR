using UnityEngine;

public class InteractWithQuestion2 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    public MeshFilter MeshFilter;
    public Mesh meshA;
    public Mesh meshB;
    public Mesh meshC;
    public Mesh meshD;
    public Mesh meshDefault;

    public GameObject Question2Selections;


    public GameObject RedX;
    public GameObject Tick;

    public AudioSource Q2;
    public GameObject Jonah;

    public AudioSource PlayBoiCarti;
    public AudioSource Kahoot;
    public AudioSource samcore;
    void Start()
    {
        outline = gameObject.GetComponent<Outline>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.Q2Selected != "NONE")
        {
            if (JR1STATICMANAGER.Q2Selected == "A"
                ||
                JR1STATICMANAGER.Q2Selected == "C"
                ||
                JR1STATICMANAGER.Q2Selected == "D"
                ||
                JR1STATICMANAGER.Q2Selected == "B")
            {
                if (JR1STATICMANAGER.Q2Selected == "A")
                {
                    Kahoot.Play();
                }
                else if (JR1STATICMANAGER.Q2Selected == "B")
                {
                    samcore.Play();
                }
                else if (JR1STATICMANAGER.Q2Selected == "C")
                {
                    PlayBoiCarti.Play();
                }


                    RedX.SetActive(true);
                Destroy(gameObject);
                Question2Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 2;
            }


        }

        if (JR1STATICMANAGER.Q2Selected == "A")
        {
            MeshFilter.mesh = meshA;
        }
        else if (JR1STATICMANAGER.Q2Selected == "B")
        {
            MeshFilter.mesh = meshB;
        }
        else if (JR1STATICMANAGER.Q2Selected == "C")
        {
            MeshFilter.mesh = meshC;
        }
        else if (JR1STATICMANAGER.Q2Selected == "D")
        {
            MeshFilter.mesh = meshD;
        }
        else
        {
            MeshFilter.mesh = meshDefault;
        }



        if (outline.enabled == true && Input.GetKeyDown(KeyCode.E) && donethething == false)
        {
            gameObject.GetComponent<Animator>().Play("GoIntoPos");
            donethething = true;
            outline.enabled = false;
            gameObject.tag = "Untagged";
            Question2Selections.SetActive(true);

            
        }

    }
}

