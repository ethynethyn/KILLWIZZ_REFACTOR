using UnityEngine;

public class JonahLastRoomScript : MonoBehaviour
{
    public AudioSource JonahSpeakingWithGob;


    public JonahCrazySpeachScript jonahCrazy;
    public GameObject goblin;

    public ChangeToIdle CTI;
    public void CTIs()
    {
        CTI.gotowall();
    }
    public void JonahSpeakWithGob()
    {
        JonahSpeakingWithGob.Play();
    }


    public void goblinActivate()
    {
        goblin.SetActive(true);
    }
    public void JonahComesUptToyou()
    {
        jonahCrazy.enabled = true;
        gameObject.GetComponent<Animator>().enabled = false;
        CTIs(); 
    }
}
