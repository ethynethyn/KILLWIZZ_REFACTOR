using StarterAssets;
using UnityEngine;

public class JonahStartingRoomManager : MonoBehaviour
{
    public FirstPersonController fpsControl;
    private float timer = 4f;
    public GameObject NormalRoom;
    public GameObject AshRoom;
    void Start()
    {
        fpsControl.MoveSpeed = 0;
    }
    
    private void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {
            NormalRoom.SetActive(false);
            AshRoom.SetActive(true);
        }
    }

}
