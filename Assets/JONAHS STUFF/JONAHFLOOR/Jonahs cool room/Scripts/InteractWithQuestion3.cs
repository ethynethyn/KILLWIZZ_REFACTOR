using UnityEngine;

public class InteractWithQuestion3 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    public MeshFilter MeshFilter;
    public Mesh meshA;
    public Mesh meshB;
    public Mesh meshC;
    public Mesh meshD;
    public Mesh meshDefault;

    public GameObject Question3Selections;


    public GameObject RedX;
    public GameObject Tick;

    public AudioSource Q3;
    public GameObject Jonah;
    public GameObject JonahHair;


    void Start()
    {
        JonahHair.SetActive(false);
        outline = gameObject.GetComponent<Outline>();
        Q3.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.Q3Selected != "NONE")
        {
            if (JR1STATICMANAGER.Q3Selected == "A"
                ||
                JR1STATICMANAGER.Q3Selected == "C"
                ||
                JR1STATICMANAGER.Q3Selected == "D")
                
            {


                JonahHair.SetActive(true);
                RedX.SetActive(true);
                Destroy(gameObject);
                Question3Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 3;
            }
            else if (JR1STATICMANAGER.Q3Selected == "B")
            {
                JR1STATICMANAGER.questionsright++;
                JonahHair.SetActive(true);
                Tick.SetActive(true);
                Destroy(gameObject);
                Question3Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 3;
            }


        }

        if (JR1STATICMANAGER.Q3Selected == "A")
        {
            MeshFilter.mesh = meshA;
        }
        else if (JR1STATICMANAGER.Q3Selected == "B")
        {
            MeshFilter.mesh = meshB;
        }
        else if (JR1STATICMANAGER.Q3Selected == "C")
        {
            MeshFilter.mesh = meshC;
        }
        else if (JR1STATICMANAGER.Q3Selected == "D")
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
            Question3Selections.SetActive(true);


        }

    }
}
