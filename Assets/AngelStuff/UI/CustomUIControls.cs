using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CustomUIControls : MonoBehaviour
{
    public ScrollRect scrollRect;
    public float speed;
    public GameObject MainMenu;

    public bool enabled;

    public GameObject defaultselect;
    public GameObject badselection;

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
            if (EventSystem.current.currentSelectedGameObject == badselection)
                EventSystem.current.SetSelectedGameObject(defaultselect);
        }

        else
        {
            MainMenu.gameObject.SetActive(false);
        }
    }
}
