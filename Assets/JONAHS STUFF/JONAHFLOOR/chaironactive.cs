using UnityEngine;

public class chaironactive : MonoBehaviour
{
    public GameObject Player;
    public GameObject putplayerpos;
    void Start()
    {
        
        Player.transform.position = putplayerpos.transform.position;
        Player.GetComponent<CharacterController>().enabled = false;


    }


}
