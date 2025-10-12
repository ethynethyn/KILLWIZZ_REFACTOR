
using UnityEngine;

public class gtamangoleft : MonoBehaviour
{
    public Door1 door1;
    public GameObject MandialogueTrigger;
    private bool leaveGTAMAN;
    public void LeavenowGTAman()
    {
        leaveGTAMAN = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        MandialogueTrigger.SetActive(false);
        door1.SetTagToDoor1();
    }
    void Update()
    {
        if (leaveGTAMAN)
        {
            
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - Time.deltaTime * 2f);
        }
    }
}
