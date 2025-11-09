using UnityEngine;

public class bruhcamscript2 : MonoBehaviour
{
    public float maxDistance = 10f;

    private Outline currentOutline;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(
            new Vector3(Screen.width / 2f, Screen.height / 2f)
        );

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            Outline outline = hit.collider.GetComponentInParent<Outline>();
            if (outline != null)
            {
                if (currentOutline != outline)
                {
                    ClearCurrent();
                    currentOutline = outline;
                }

                currentOutline.enabled = true;
                return;
            }
        }

        ClearCurrent();
    }

    void ClearCurrent()
    {
        if (currentOutline != null)
        {
            currentOutline.enabled = false;
            currentOutline = null;
        }
    }
}