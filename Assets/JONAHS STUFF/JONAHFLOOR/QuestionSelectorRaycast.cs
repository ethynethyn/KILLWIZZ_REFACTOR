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

            }
            else
            {
                JR1STATICMANAGER.Q1Selected = "NONE";
            }

        }
        else
        {
            JR1STATICMANAGER.Q1Selected = "NONE";
        }
    }
}
