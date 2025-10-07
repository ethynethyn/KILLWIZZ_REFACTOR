using UnityEngine;
using TMPro;

public class closeUI : MonoBehaviour
{

    public GameObject canvas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            canvas.SetActive(false);
        }
    }
}
