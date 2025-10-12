using UnityEngine;

public class ExpScri : MonoBehaviour
{
    public GameObject Everything1;
    public GameObject Everything2;
    public GameObject Everything3;
    public GameObject Everything4;
    public GameObject Everything5;
    public GameObject Everything6;
    public GameObject Everything7;
    public GameObject Everything8;
    public GameObject Everything9;
    public GameObject Everything10;
    public GameObject Everything11;
    public GameObject Everything12;
    public GameObject Everything13;
    public GameObject Everything14;
    public GameObject Everything15;
    public GameObject Everything16;
    public CharacterController cc;
    public GameObject ExitEl;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void DestroyEverything()
    {
        ExitEl.SetActive(true);
        Everything1.SetActive(false);
        Everything2.SetActive(false);
        Everything3.SetActive(false);
        Everything4.SetActive(false);
        Everything5.SetActive(false);
        Everything6.SetActive(false);
        Everything7.SetActive(false);
        Everything8.SetActive(false);
        Everything9.SetActive(false);
        Everything10.SetActive(false);
        Everything11.SetActive(false);
        Everything12.SetActive(false);
        Everything13.SetActive(false);
        Everything14.SetActive(false);
        Everything15.SetActive(false);
        Everything16.SetActive(false);

        cc.enabled = (true);

    }


}
