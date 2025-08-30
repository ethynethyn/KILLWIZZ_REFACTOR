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
}
