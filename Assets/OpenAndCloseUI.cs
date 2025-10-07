using UnityEngine;

public class OpenAndCloseUI : MonoBehaviour
{
    public GameObject canvas;
    public bool isDone = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab) && isDone == false)
        {
            canvas.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            canvas.SetActive(false);
            isDone = true;
        }

    }
}
