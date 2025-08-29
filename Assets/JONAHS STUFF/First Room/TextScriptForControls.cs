using UnityEngine;

public class TextScriptForControls : MonoBehaviour
{
    public GameObject WASD;
    public GameObject SPACE;
    public GameObject EtoInteract;
    
    void Update()
    {
        if (gameObject.name == "WASD")
        {
            if (Input.GetKey(KeyCode.W)
                || Input.GetKey(KeyCode.S)
                || Input.GetKey(KeyCode.D)
                || Input.GetKey(KeyCode.A))
            {
                WASD.SetActive(false);
                SPACE.SetActive(true);
            }
        }
        if (gameObject.name == "SPACE")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SPACE.SetActive(false);
                EtoInteract.SetActive(true);
            }
        }

    }
}
