using NUnit.Framework.Internal;
using System.Transactions;
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

    public GameObject phone;
    public Mesh Siberna;
    public Mesh iceD;
    public Mesh water;
    public Mesh twinGun;
    public HandleMusicAnimation HMA;
    private bool haspressedW;

    public AudioSource ShootNoise;
    
    public void Shootbruh()
    {
        ShootNoise.Play();
    }
    private void Awake()
    {
        haspressedW = false;

    }
    public void TurnOffAnimator()
    {
        animator.enabled = false;
    }
    public void ActivatePhone()
    {
        phone.SetActive(true);
        MeshFilter meshFilter = phone.GetComponent<MeshFilter>();
        meshFilter.mesh = water;
        HMA.StartMusicPart();
    }

    public void Twin()
    {
        MeshFilter meshFilter = phone.GetComponent<MeshFilter>();
        meshFilter.mesh = twinGun;

    }
    public void Sem()
    {
        MeshFilter meshFilter = phone.GetComponent<MeshFilter>();
        meshFilter.mesh = Siberna;

    }
    public void IceD()
    {
        MeshFilter meshFilter = phone.GetComponent<MeshFilter>();
        meshFilter.mesh = iceD;

    }


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
    [SerializeField] private Transform target; // drag your Player Capsule here in Inspector

    public GameObject player;

    public void FallSky()
    {
        if (JR1STATICMANAGER.alreadydone == false)
        {
            gameObject.GetComponent<Animator>().Play("Room tour");
            Explosion.SetActive(true);
            JR1STATICMANAGER.alreadydone = true;


        }
        else
        {
            gameObject.GetComponent<Animator>().Play("AlreadyDone");
            Explosion.SetActive(true);

        }
    }
    void Update()
    {


        // Find direction to the player
        Vector3 direction = player.transform.position - transform.position;

        // Flatten the direction so character only rotates around Y axis
        direction.y = 0;

        // Only rotate if there’s actually a direction to look at
        if (direction.sqrMagnitude > 0.001f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
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
