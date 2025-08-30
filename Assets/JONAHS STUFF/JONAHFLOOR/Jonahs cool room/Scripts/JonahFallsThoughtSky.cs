using UnityEngine;

public class JonahFallsThoughtSky : MonoBehaviour
{
    public Animator animator;
    public AudioSource Audio1;

    public GameObject pointAtWhichJonahStops;
    public GameObject JonahGameObject;
    public GameObject Explosion;

    private bool startnow = false;
    public AudioSource bestbuy;

    public void PlayAudio()
    {
        Audio1.Play();
    }
    public void TurnOnbestBuy()
    {
        bestbuy.Play();
    }

    public void TurnOffbestBuy()
    {
        bestbuy.Stop();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameObject.GetComponent<Animator>().Play("Room tour");
            Explosion.SetActive(true);


            //startnow = true;
        }

        if (startnow == true)
        {
            JonahGameObject.transform.position =
                new Vector3(JonahGameObject.transform.position.x ,
                JonahGameObject.transform.position.y - Time.deltaTime * 10f,
                JonahGameObject.transform.position.z );

            if (JonahGameObject.transform.position.y <
                pointAtWhichJonahStops.transform.position.y)
            {
                startnow = false;
            }

        }

    }
}
