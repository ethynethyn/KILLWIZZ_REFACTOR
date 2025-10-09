using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UIElements;


public class HandleMusicAnimation : MonoBehaviour
{
    private string lastQ1Value;
    private string lastQ2Value;

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
    public AudioSource question2;
    public GameObject question2GO;
    public GameObject question3GO;
    public GameObject question4GO;
    public GameObject question5GO;
    public AudioSource sitdown;

    public AudioSource Q5Audio;


    public AudioSource End0;
    public AudioSource End1;
    public AudioSource End2;
    public AudioSource End3;
    public AudioSource End4;
    public AudioSource End5;

    public GameObject youfailed;
    public GameObject DoExplode;

    public GameObject JonahGun;

    public void shoottoKill()
    {
        JonahGun.SetActive(true);
        gameObject.SetActive(false);
    }
    public void explode()
    {
        DoExplode.SetActive(true);
    }

    public void YouFailedCome()
    {
        youfailed.SetActive(true);
    }
    public void YouFailedGoAway()
    {
        youfailed.SetActive(false);

    }
    public void LoseOrWin()
    {
        if (JR1STATICMANAGER.questionsright > 2)
        {
            animator.Play("passed");

        }
        else
        {
            animator.Play("failed");
        }
    }
    public void WinAudio()
    {
        if (JR1STATICMANAGER.questionsright == 3)
        {
            End3.Play();
        }
        else if (JR1STATICMANAGER.questionsright == 4)
        {
            End4.Play();
        }
        else if (JR1STATICMANAGER.questionsright == 5)
        {
            End5.Play();
        }
    }
    public void LostAudio()
    {
        if (JR1STATICMANAGER.questionsright == 0)
        {
            End0.Play();
        }
        else if (JR1STATICMANAGER.questionsright == 1)
        {
            End1.Play();
        }
        else if (JR1STATICMANAGER.questionsright == 2)
        {
            End2.Play();
        }
    }
    public void sitdownbro()
    {
        sitdown.Play();
    }
    public void PlayQuestion2()
    {
        question2.Play();
        question2GO.SetActive(true);
    }
    public void PlayQuestion3()
    {
        question3GO.SetActive(true);
    }
    public void PlayQuestion4()
    {
        question4GO.SetActive(true);
    }

    public void Question5Paper()
    {
        question5GO.SetActive(true);
    }
    public void PlayQuestion5Audio()
    {
        Q5Audio.Play();
    }

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
    bool IsInAnimation(string animName, int layer = 0)
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(layer);
        return stateInfo.IsName(animName);
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

        var currentValue2 = JR1STATICMANAGER.Q2Selected;
        if (currentValue2 != lastQ2Value && currentValue2 != "NONE")
        {

           if (JR1STATICMANAGER.Q2Selected == "C")
           {
                animator.Play("playboi carti come");
                if (question2.isPlaying)
                {
                    question2.Stop();
                }

           }
           else if (IsInAnimation("playboi carti come"))
           {
                animator.Play("playboi carti leave");
           }

        }
        else if (IsInAnimation("playboi carti come") && currentValue2 == "NONE")
        {
            animator.Play("playboi carti leave");
        }

            lastQ2Value = currentValue2;




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
