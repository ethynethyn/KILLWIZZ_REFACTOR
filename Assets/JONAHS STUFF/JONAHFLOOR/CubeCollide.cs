using UnityEngine;

public class CubeCollide : MonoBehaviour
{
    public JonahFallsThoughtSky jfs;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PC")
        {
            jfs.FallSky();
            Destroy(gameObject);
        }
    }
}
