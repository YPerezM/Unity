using UnityEngine;
using System.Collections;

public class MenuPausa : MonoBehaviour {

    public string mainMenu;
    public bool isPaused;
    public GameObject pauseMenuCanvas;

	
	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0;
            
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }
    }

    public void Reanudar()
    {
        isPaused = false;
    }

    public void Salir()
    {
        Application.LoadLevel("Main_menu");
    }
    
    //CODIGO PARA PARAR EL JUEGO PULSANDO TECLA ESC
    /*if (Input.GetKeyDown(KeyCode.P))
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;


        }
        else
        {
            Time.timeScale = 1;
        }
    }*/
}
