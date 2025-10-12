using UnityEngine;

public class JR1STATICMANAGER : MonoBehaviour
{

    public static bool MainRoomdoor1;

    public static string Q1Selected = "NONE";
    public static string Q2Selected = "NONE";
    public static string Q3Selected = "NONE";
    public static string Q4Selected = "NONE";
    public static string Q5Selected = "NONE";
    public static int questiondone;
    public static bool alreadydone;

    public static int questionsright;
    private void Awake()
    {
        
        StaticSONIC.SonicShoot = false;
        MainRoomdoor1 = false;
        Q1Selected = "NONE";
        Q2Selected = "NONE";
        Q3Selected = "NONE";
        Q4Selected = "NONE";
        Q5Selected = "NONE";
        questiondone = 0;
        questionsright = 0;
    }
}
