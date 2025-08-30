using UnityEngine;

public class MouthSwitcherAnimatorJonah : MonoBehaviour
{
    public Mesh closedMouthMesh;
    public Mesh openMouthMesh;

    public Material closedMouthMat; // has face+mouth closed texture
    public Material openMouthMat;   // has face+mouth open texture

    private MeshFilter meshFilter;
    private Renderer rend;
    private bool mouthOpen;

    private bool isAnyAudioPlaying;
    private bool MouthClosed = true;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        rend = GetComponent<Renderer>();
    }
    public void MouthSwitch()
    {
        if (MouthClosed)
        {
            meshFilter.mesh = openMouthMesh;

            // Get current materials
            Material[] mats = rend.materials;
            mats[1] = openMouthMat; // only change the mouth slot
            rend.materials = mats;
            MouthClosed = false;

            //mouthOpen = !mouthOpen;
            //if (mouthOpen)
            //{
            //    meshFilter.mesh = openMouthMesh;

            //    // Get current materials
            //    Material[] mats = rend.materials;
            //    mats[1] = openMouthMat; // only change the mouth slot
            //    rend.materials = mats;
            //}
            //else
            //{
            //    meshFilter.mesh = closedMouthMesh;

            //    // Get current materials
            //    Material[] mats = rend.materials;
            //    mats[1] = closedMouthMat; // only change the mouth slot
            //    rend.materials = mats;
            //}
        }
        else
        {
            meshFilter.mesh = closedMouthMesh;

            //    // Get current materials
            Material[] mats = rend.materials;
            mats[1] = closedMouthMat; // only change the mouth slot
            rend.materials = mats;
            MouthClosed = true;
        }
    }
    void Update()
    {
        AudioSource[] audioSources = GetComponents<AudioSource>();

        isAnyAudioPlaying = false; // reset before checking
        foreach (AudioSource source in audioSources)
        {
            if (source.isPlaying)
            {
                isAnyAudioPlaying = true;
                break; // no need to check the rest
            }
        }





        // chat gpt wrote all of this code


    }
}
