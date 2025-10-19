using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverDetector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public JonahStartingRoomManager roomManager;

    public GameObject notgreen;
    public GameObject green;
    public GameObject Player;
    public GameObject PlayerFollowCamera;
    [Tooltip("This will be true when the button is being hovered over.")]
    public bool isHovered = false;

    // Called when the mouse starts hovering over the button
    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovered = true;
        green.SetActive(true);
        notgreen.SetActive(false);


    }

    // Called when the mouse stops hovering over the button
    public void OnPointerExit(PointerEventData eventData)
    {
        isHovered = false;
        notgreen.SetActive(true);
        green.SetActive(false);

    }
    private void Update()
    {
        if (isHovered)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Player.SetActive(true);
                PlayerFollowCamera.SetActive(true);
                green.SetActive(false);
                notgreen.SetActive(false);
                gameObject.SetActive(false);
                roomManager.startCutscene = true;
            }
        }
    }
}