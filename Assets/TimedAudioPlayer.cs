using UnityEngine;

public class TimedAudioPlayer : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioSource audioSource;   // Drag your AudioSource here
    public AudioClip soundClip;       // Drag your sound here
    public float playDuration = 2f;   // How many seconds to play
    public float delayBeforePlay = 3f; // Wait this long before playing

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (soundClip != null)
        {
            Invoke(nameof(PlaySoundForDuration), delayBeforePlay);
        }
    }

    private void PlaySoundForDuration()
    {
        audioSource.clip = soundClip;
        audioSource.Play();

        // Stop after playDuration
        Invoke(nameof(StopSound), playDuration);
    }

    private void StopSound()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
