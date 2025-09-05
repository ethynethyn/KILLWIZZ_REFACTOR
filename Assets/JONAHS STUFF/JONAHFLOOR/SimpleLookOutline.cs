using UnityEngine;

public class SimpleLookOutline : MonoBehaviour
{
    public float maxDistance = 10f;

    private Outline currentOutline;

    void Update()
    {
        // ray from player forward
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            if (hit.collider.CompareTag("Outline"))
            {
                Outline outline = hit.collider.GetComponent<Outline>();
                if (outline != null)
                {
                    // switch outlines if looking at a new object
                    if (currentOutline != outline)
                    {
                        ClearCurrent();
                        currentOutline = outline;
                    }

                    currentOutline.enabled = true;
                    return;
                }
            }
        }

        // if not hitting a tagged outline object, clear
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