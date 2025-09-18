using UnityEngine;
using System.Collections;
using UnityEngine.Audio;


public class HandleMusicAnimation : MonoBehaviour
{
    private string lastQ1Value;

    public GameObject Explosion2;
    public GameObject littlechair;

    public Animator animator;

    public MouthSwitcherAnimatorJonah MSA;
    public JonahFallsThoughtSky JFTS;

    public AudioSource MusicAudio;
    private float timer = 2f;
    private bool sM;
    private bool MhasStarted;
    private bool STARTTEST;

    public GameObject phone;
    public AudioSource Enought;

    public GameObject lights;
    public GameObject Lights2;

    public AudioSource Q1;
    public AudioSource Ohyougonnapickthatone;

    public AudioSource Orthatone;

    public void OrThatOnetriggered()
    {
        if (Ohyougonnapickthatone.isPlaying)
        {
            
        }
        else
        {
            Orthatone.Play();

        }
    }
    public void Question1()
    {
        Q1.Play();
    }

    public void Ohhyougonna()
    {
        Ohyougonnapickthatone.Play();
    }

    public void EnableLights2()
    {
        //Lights2.SetActive(true);
    }
    public void EnableLights22()
    {
        Lights2.SetActive(true);
    }
    public void disableLights22()
    {
        Lights2.SetActive(false);

    }
    public void disabletheLights()
    {
        lights.SetActive(false);
    }
    public void enabletheLights()
    {
        lights.SetActive(true);

    }
    public void StartMusicPart()
    {
        sM = true;
    }
    private IEnumerator PlayStartTest()
    {
        animator.enabled = true;                              // (re)enable
        yield return null;                                    // wait one frame
        animator.cullingMode = AnimatorCullingMode.AlwaysAnimate;
        animator.speed = 1f;
        animator.updateMode = AnimatorUpdateMode.Normal;      // avoid physics step gating
        //, 0, 0f);                    // base layer, start at 0
    }
    void Update()
    {

        var currentValue = JR1STATICMANAGER.Q1Selected;
        if (currentValue != lastQ1Value && currentValue != "NONE")
        {
            
            if (!Ohyougonnapickthatone.isPlaying)
            {
                animator.Play("orthatone", 0, 0f);

            }
        }
        lastQ1Value = currentValue;
        //if (!MusicAudio.isPlaying && fulldone == true && STARTTEST == false)
        //{
        //    // I HAVE NO IDEA WHY DISABLABLING THIS SCRIPT WOULD DO ANYTHING BUT IT DOES 
        //    //JFTS.enabled = false;
        //    print("this code runing");
        //    animator.enabled = true;
        //    animator.Play("startTEST");
        //    STARTTEST = true;
        //}
        if (!MusicAudio.isPlaying && fulldone && !STARTTEST)
        {
            STARTTEST = true;                 // prevent re-entry
            //StartCoroutine(PlayStartTest());

            phone.SetActive(false);
            Enought.Play();
            lights.SetActive(true);
            animator.enabled = true;                              // (re)enable
            //animator.Play("startTEST", 0, 0f);

        }



        if (sM == true && MhasStarted == false)
        {
            timer = timer - Time.deltaTime;
            if (timer < 0f)
            {
                MusicAudio.Play();
                MSA.MouthSwitch();
                StartCoroutine(butterfly());

                StartCoroutine(CloseMouthAfterDelay());
                MhasStarted = true;
            }
        }
    }
    private IEnumerator butterfly()
    {
        yield return new WaitForSeconds(2.8f);
        JFTS.Twin();
        StartCoroutine(sem());

    }
    private IEnumerator sem()
    {
        yield return new WaitForSeconds(2.1f);
        JFTS.Sem();
        StartCoroutine(IceD());

    }
    private IEnumerator IceD()
    {
        yield return new WaitForSeconds(1f);
        JFTS.IceD();
    }



    private IEnumerator CloseMouthAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        MSA.MouthSwitch();
        StartCoroutine(CloseMouthAfterDelay2());

    }
    private IEnumerator CloseMouthAfterDelay2()
    {
        yield return new WaitForSeconds(2.5f);
        MSA.MouthSwitch();
        StartCoroutine(CloseMouthAfterDelay3());


    }
    private IEnumerator CloseMouthAfterDelay3()
    {
        yield return new WaitForSeconds(0.6f);
        MSA.MouthSwitch();
        StartCoroutine(CloseMouthAfterDelay4());


    }
    private IEnumerator CloseMouthAfterDelay4()
    {
        yield return new WaitForSeconds(1.5f);
        MSA.MouthSwitch();
        StartCoroutine(CloseMouthAfterDelay5());

    }
    private IEnumerator CloseMouthAfterDelay5()
    {
        yield return new WaitForSeconds(1.5f);
        MSA.MouthSwitch();
        StartCoroutine(CloseMouthAfterDelay6());


    }
    private bool fulldone;
    private IEnumerator CloseMouthAfterDelay6()
    {
        yield return new WaitForSeconds(1.8f);
        MSA.MouthSwitch();

        fulldone = true;
    }

    public void SecondExp()
    {
        Explosion2.SetActive(true);
    }

    public void SitDownChair()
    {
        littlechair.SetActive(true);
    }
}
