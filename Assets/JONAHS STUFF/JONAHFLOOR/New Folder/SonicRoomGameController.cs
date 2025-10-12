using UnityEngine;

public class SonicRoomGameController : MonoBehaviour
{
    public GameObject SonicDialogueTrigger;

    public GameObject realsonic;
    public GameObject fakesonic;
    public GameObject gtaman;
    private bool done;


    public void YouWearSonicsSkin()
    {
        if (done == false)
        {
            SonicDialogueTrigger.SetActive(false);
            realsonic.SetActive(false);
            fakesonic.SetActive(true);
            //gtaman.SetActive(true);
            done = true;
        }

    }
}
