using UnityEngine;

public class ChildFuctionHandler : MonoBehaviour
{
    public GameObject child;
    public void MouthSwitcherDo()
    {
        if (child != null)
        {
            child.GetComponent<MouthSwitcherAnimatorJonah>().MouthSwitch();
        }
    }
    public void ForceCloseDo()
    {
        if (child != null)
        {
            child.GetComponent<MouthSwitcherAnimatorJonah>().ForceClose();
        }
    }
    public void ForceOpenDo()
    {
        if (child != null)
        {
            child.GetComponent<MouthSwitcherAnimatorJonah>().ForceOpen();
        }
    }
}
