using UnityEngine;

public class QuestionSelectorRaycast : MonoBehaviour
{
    public float maxDistance = 10f;

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            if (hit.collider.CompareTag("Question"))
            {
                
                if (hit.collider.name == ("Q1A"))
                {
                    JR1STATICMANAGER.Q1Selected = "A";
                }
                else if (hit.collider.name == ("Q1B"))
                {
                    JR1STATICMANAGER.Q1Selected = "B";

                }
                else if (hit.collider.name == ("Q1C"))
                {
                    JR1STATICMANAGER.Q1Selected = "C";

                }
                else if (hit.collider.name == ("Q1D"))
                {
                    JR1STATICMANAGER.Q1Selected = "D";

                }
                else if (hit.collider.name == ("Q2A"))
                {
                    JR1STATICMANAGER.Q2Selected = "A";
                }
                else if (hit.collider.name == ("Q2B"))
                {
                    JR1STATICMANAGER.Q2Selected = "B";

                }
                else if (hit.collider.name == ("Q2C"))
                {
                    JR1STATICMANAGER.Q2Selected = "C";

                }
                else if (hit.collider.name == ("Q2D"))
                {
                    JR1STATICMANAGER.Q2Selected = "D";

                }


            }
            else
            {
                JR1STATICMANAGER.Q1Selected = "NONE";
                JR1STATICMANAGER.Q2Selected = "NONE";
            }

        }
        else
        {
            JR1STATICMANAGER.Q1Selected = "NONE";
            JR1STATICMANAGER.Q2Selected = "NONE";
        }
    }
}
