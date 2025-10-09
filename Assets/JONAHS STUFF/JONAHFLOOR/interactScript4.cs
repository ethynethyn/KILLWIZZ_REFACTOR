using UnityEngine;

public class interactScript4 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    public MeshFilter MeshFilter;
    public Mesh meshA;
    public Mesh meshB;
    public Mesh meshC;
    public Mesh meshD;
    public Mesh meshDefault;

    public GameObject Question4Selections;


    public GameObject RedX;
    public GameObject Tick;

    public AudioSource Q4;
    public GameObject Jonah;

    public GameObject JonahOGrender;
    public GameObject jonahDancing;

    public AudioSource carti;
    public AudioSource kahoot;
    public AudioSource samcore;

    void Start()
    {
        
        outline = gameObject.GetComponent<Outline>();
        Q4.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.Q4Selected != "NONE")
        {
            if (JR1STATICMANAGER.Q4Selected == "A"
                ||
                JR1STATICMANAGER.Q4Selected == "B"
                ||
                JR1STATICMANAGER.Q4Selected == "D")

            {
                if (carti.isPlaying)
                {
                    carti.Stop();

                }
                if (kahoot.isPlaying)
                {
                    kahoot.Stop();

                }
                if (samcore.isPlaying)
                {
                    samcore.Stop();

                }



                jonahDancing.SetActive(false);
                JonahOGrender.SetActive(true);

                RedX.SetActive(true);
                Destroy(gameObject);
                Question4Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 4;
            }
            else if (JR1STATICMANAGER.Q4Selected == "C")
            {
                if (carti.isPlaying)
                {
                    carti.Stop();

                }
                if (kahoot.isPlaying)
                {
                    kahoot.Stop();

                }
                if (samcore.isPlaying)
                {
                    samcore.Stop();

                }
                JR1STATICMANAGER.questionsright++;
                jonahDancing.SetActive(false);
                JonahOGrender.SetActive(true);

                Tick.SetActive(true);
                Destroy(gameObject);
                Question4Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 4;
            }


        }

        if (JR1STATICMANAGER.Q4Selected == "A")
        {
            MeshFilter.mesh = meshA;
        }
        else if (JR1STATICMANAGER.Q4Selected == "B")
        {
            MeshFilter.mesh = meshB;
        }
        else if (JR1STATICMANAGER.Q4Selected == "C")
        {
            MeshFilter.mesh = meshC;
        }
        else if (JR1STATICMANAGER.Q4Selected == "D")
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
            Question4Selections.SetActive(true);
            jonahDancing.SetActive(true);
            JonahOGrender.SetActive(false);
        }

    }
}
