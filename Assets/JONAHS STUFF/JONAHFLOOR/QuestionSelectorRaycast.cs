using UnityEngine;

public class QuestionSelectorRaycast : MonoBehaviour
{
    public float maxDistance = 10f;

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f))
        {

            if (hit.collider.CompareTag("Door1"))
            {
                JR1STATICMANAGER.MainRoomdoor1 = true;
            }
            else
            {
                JR1STATICMANAGER.MainRoomdoor1 = false;
            }








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



                else if (hit.collider.name == ("Q3A"))
                {
                    JR1STATICMANAGER.Q3Selected = "A";
                }
                else if (hit.collider.name == ("Q3B"))
                {
                    JR1STATICMANAGER.Q3Selected = "B";

                }
                else if (hit.collider.name == ("Q3C"))
                {
                    JR1STATICMANAGER.Q3Selected = "C";

                }
                else if (hit.collider.name == ("Q3D"))
                {
                    JR1STATICMANAGER.Q3Selected = "D";

                }



                else if (hit.collider.name == ("Q4A"))
                {
                    JR1STATICMANAGER.Q4Selected = "A";
                }
                else if (hit.collider.name == ("Q4B"))
                {
                    JR1STATICMANAGER.Q4Selected = "B";

                }
                else if (hit.collider.name == ("Q4C"))
                {
                    JR1STATICMANAGER.Q4Selected = "C";

                }
                else if (hit.collider.name == ("Q4D"))
                {
                    JR1STATICMANAGER.Q4Selected = "D";

                }





                else if (hit.collider.name == ("Q5A"))
                {
                    JR1STATICMANAGER.Q5Selected = "A";
                }
                else if (hit.collider.name == ("Q5B"))
                {
                    JR1STATICMANAGER.Q5Selected = "B";

                }
                else if (hit.collider.name == ("Q5C"))
                {
                    JR1STATICMANAGER.Q5Selected = "C";

                }
                else if (hit.collider.name == ("Q5D"))
                {
                    JR1STATICMANAGER.Q5Selected = "D";

                }
            }
            else
            {
                JR1STATICMANAGER.Q1Selected = "NONE";
                JR1STATICMANAGER.Q2Selected = "NONE";
                JR1STATICMANAGER.Q3Selected = "NONE";
                JR1STATICMANAGER.Q4Selected = "NONE";
                JR1STATICMANAGER.Q5Selected = "NONE";
            }

        }
        else
        {
            JR1STATICMANAGER.Q1Selected = "NONE";
            JR1STATICMANAGER.Q2Selected = "NONE";
            JR1STATICMANAGER.Q3Selected = "NONE";
            JR1STATICMANAGER.Q4Selected = "NONE";
            JR1STATICMANAGER.Q5Selected = "NONE";
            JR1STATICMANAGER.MainRoomdoor1 = false;
        }
    }
}
