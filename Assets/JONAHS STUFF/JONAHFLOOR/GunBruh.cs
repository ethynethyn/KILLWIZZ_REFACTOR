using UnityEngine;

public class GunBruh : MonoBehaviour
{
    public AudioSource shootnoise;

    public GameObject shotCanvas;

    public void shootgunbruh()
    {
        shootnoise.Play();
    }
    public void Resetnow()
    {
        shotCanvas.SetActive(true);
    }
}
