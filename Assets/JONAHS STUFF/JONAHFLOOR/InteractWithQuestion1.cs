using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.Audio;

public class InteractWithQuestion1 : MonoBehaviour
{
    private Outline outline;
    private bool donethething;
    public MeshFilter MeshFilter;   
    public Mesh meshA;
    public Mesh meshB;
    public Mesh meshC;
    public Mesh meshD;
    public Mesh meshDefault;

    public GameObject Question1Selections;


    public GameObject RedX;
    public GameObject Tick;

    public AudioSource Q1;
    public GameObject Jonah;


    void Start()
    {
        outline = gameObject.GetComponent<Outline>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && JR1STATICMANAGER.Q1Selected != "NONE")
        {
            if (JR1STATICMANAGER.Q1Selected == "A"
                ||
                JR1STATICMANAGER.Q1Selected == "C"
                ||
                JR1STATICMANAGER.Q1Selected == "D")
            {
                RedX.SetActive(true);
                Destroy(gameObject);
                Question1Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 1;
            }
            else if (JR1STATICMANAGER.Q1Selected == "B")
            {
                JR1STATICMANAGER.questionsright++;
                Tick.SetActive(true);
                Destroy(gameObject);
                Question1Selections.SetActive(false);
                JR1STATICMANAGER.questiondone = 1;
            }

        }

        if (JR1STATICMANAGER.Q1Selected == "A")
        {
            MeshFilter.mesh = meshA;
        }
        else if (JR1STATICMANAGER.Q1Selected == "B")
        {
            MeshFilter.mesh = meshB;
        }
        else if (JR1STATICMANAGER.Q1Selected == "C")
        {
            MeshFilter.mesh = meshC;
        }
        else if (JR1STATICMANAGER.Q1Selected == "D")
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
            Question1Selections.SetActive(true);
            if (Q1.isPlaying)
            {
                Q1.Stop();
            }
            Jonah.GetComponent<Animator>().Play("ohyougonnapickthatone");
        }

    }
}
