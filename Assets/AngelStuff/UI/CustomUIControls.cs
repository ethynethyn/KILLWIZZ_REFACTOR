using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomUIControls : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float speed;
    public GameObject MainMenu;


    public GameObject defaultselect;
    public GameObject badselection;

    public void Start()
    {
        EventSystem.current.SetSelectedGameObject(defaultselect);
    }

    // Update is called once per frame
    void Update()
    {
        //scroll();
        
            showUI();
        

            
    }

    //LEGACY CODE


    //public void scroll()
    //{
    //    //Scrolls down
    //    Vector2 velocity = Vector2.zero;
    //    if (Input.GetAxis("Mouse ScrollWheel") < 0f)
    //    {
    //        velocity = Vector2.up * speed * 10;
    //    }

    //    //scrolls up
    //    else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
    //    {
    //        velocity = -Vector2.up * speed * 10;
    //    }
    //    scrollRect.velocity = velocity;
    //}

    public void showUI()
    {
        if(Input.GetKey(KeyCode.Tab) && enabled == true)
        {
           MainMenu.gameObject.SetActive(true);
        }

        else
        {
            MainMenu.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Tab) && enabled == true)
        {
            if (EventSystem.current.currentSelectedGameObject != defaultselect)
                EventSystem.current.SetSelectedGameObject(defaultselect);
        }
    }
}
