using UnityEngine;
using UnityEngine.UI; // IMPORTANT for UI Image


public class ifm1des : MonoBehaviour
{
    public Sprite scroll;
    private Image image;
    private bool hasm1ed;

    private void Start()
    {
        image = GetComponent<Image>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            image.sprite = scroll;
            hasm1ed = true;
        }

        float scrol1l = Input.GetAxis("Mouse ScrollWheel");
        if (scrol1l < 0f && hasm1ed)
        {
            Destroy(gameObject);
        }
    }
}
