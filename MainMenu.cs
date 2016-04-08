using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public bool isStart;
    public bool isInfo;
    public bool isQuit;

    void OnMouseUp()
    {
        if (isStart)
        {
            Application.LoadLevel("scene_race_track");
        }
        if (isInfo)
        {
            Application.LoadLevel("Info_Menu");
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }
}
