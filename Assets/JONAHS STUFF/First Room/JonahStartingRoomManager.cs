using StarterAssets;
using UnityEngine;
using UnityEngine.Audio;

public class JonahStartingRoomManager : MonoBehaviour
{
    public FirstPersonController fpsControl;
    private float timer = 7f;
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
    void Start()
    {
        fpsControl.MoveSpeed = 0;
        fpsControl.SprintSpeed = 0;
        fpsControl.JumpHeight = 0;
    }
    
    private void Update()
    {
        timer = timer - Time.deltaTime;
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
                PlayerAnimator.Play("PlayerAnimation jonah sceme");
                playerGround = true;
            }


        }
    }


}
