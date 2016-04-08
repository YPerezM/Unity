using UnityEngine;
using System.Collections;

public class VolverMenu : MonoBehaviour {

    public bool isVolver;
    
    void OnMouseUp()
    {
        if (isVolver)
        {
            Application.LoadLevel("Main_menu");
        }
        
    }
}
