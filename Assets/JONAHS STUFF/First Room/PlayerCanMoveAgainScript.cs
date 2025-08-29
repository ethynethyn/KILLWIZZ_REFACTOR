using StarterAssets;
using UnityEngine;

public class PlayerCanMoveAgainScript : MonoBehaviour
{
    public FirstPersonController fpsC;
    public GameObject ControlCanvas;
    public Animator PlayerAnim;
    public void PlayerCanMoveNow()
    {
        fpsC.MoveSpeed = 4;
        fpsC.SprintSpeed = 6;
        fpsC.JumpHeight = 1f;
        ControlCanvas.SetActive(true);
        //PlayerAnim.Play("Normal player");
    }

}
