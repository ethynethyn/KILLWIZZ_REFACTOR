using UnityEngine;

public class minecraftSonicScript : MonoBehaviour
{
    public GameObject crazy;
    public GameObject gun;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            playshoot();
        }
    }
    public void playshoot()
    {
        gun.SetActive(true);
        gameObject.GetComponent<Animator>().Play("gun");
        StaticSONIC.SonicShoot = true;
    }

    public void PlayCRAZY()
    {
        crazy.SetActive(true);
    }
}
