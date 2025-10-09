using UnityEngine;

public class SonicRoomGameController : MonoBehaviour
{
    public GameObject realsonic;
    public GameObject fakesonic;
    public GameObject gtaman;
    private bool done;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && done == false)
        {
            done = true;
            realsonic.SetActive(false);
            fakesonic.SetActive(true);
            gtaman.SetActive(true);
        }
    }
}
