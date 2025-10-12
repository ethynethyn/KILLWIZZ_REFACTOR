using System.Threading;
using UnityEngine;

public class SonicRoomManager : MonoBehaviour
{
    public minecraftSonicScript mcsc;
    private float timer = 1.7f;
    private bool timerstart = false;
    public GameObject dialoguetrigger;
    public void WRONG()
    {
        timerstart = true;
    }
    private void Update()
    {
        if (timerstart)
        {
            dialoguetrigger.SetActive(false);
            timer = timer - Time.deltaTime;
            if (timer < 0)
            {
                timerstart = false;
                mcsc.playshoot();
            }
        }

    }
}
