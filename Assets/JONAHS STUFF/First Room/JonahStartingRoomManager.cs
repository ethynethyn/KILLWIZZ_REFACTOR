using StarterAssets;
using UnityEngine;
using UnityEngine.Audio;

public class JonahStartingRoomManager : MonoBehaviour
{
    public GameObject Explosion1;
    public GameObject Explosion2;
    public GameObject Explosion3;
    public GameObject Explosion4;
    public GameObject Tv1;
    public GameObject Tv2;


    public FirstPersonController fpsControl;
    private float timer = 10f;
    private float timerForWizardSpeaking = 1f;
    private bool Exploded = false;
    private bool PlayedWizardSpeaking;
    public GameObject NormalRoom;
    public GameObject AshRoom;

    public AudioSource ExplodeAudio;
    public GameObject ExplodeAnim;

    public GameObject WizardScreens;
    public AudioSource WizardAudio;

    public Animator PlayerAnimator;
    private bool playerGround;

    public bool startCutscene;
    private bool nextpart;
    void Start()
    {
        fpsControl.MoveSpeed = 0;
        fpsControl.SprintSpeed = 0;
        fpsControl.JumpHeight = 0;
    }
    
    
    private void Update()
    {

        if (startCutscene == true)
        {
            timer = timer - Time.deltaTime;

        }




        if (timer < 0 && Exploded == false)
        {
            Exploded = true;
            NormalRoom.SetActive(false);
            AshRoom.SetActive(true);

            ExplodeAnim.SetActive(true);
            ExplodeAudio.Play();
        }


        if (!ExplodeAudio.isPlaying && Exploded == true && PlayedWizardSpeaking == false)
        {
            timerForWizardSpeaking = timerForWizardSpeaking - Time.deltaTime;

            if (timerForWizardSpeaking < 0)
            {
                Explosion1.SetActive(true);
                Explosion2.SetActive(true);
                Tv1.SetActive(false);
                Tv2.SetActive(false);
                PlayedWizardSpeaking = true;
                WizardScreens.SetActive(true);
                WizardAudio.Play();

            }

        }

        if (!WizardAudio.isPlaying && playerGround == false)
        {
            WizardScreens.SetActive(false);

            if (PlayedWizardSpeaking == true)
            {
                Explosion3.SetActive(true);
                Explosion4.SetActive(true);
                PlayerAnimator.Play("PlayerAnimation jonah sceme");
                playerGround = true;
            }


        }
    }


}
