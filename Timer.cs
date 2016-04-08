using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timerText;
    public Text finishText;
    private float startTime;
    private float timeLeft=5;
    private bool finnished = false;

	// Use this for initialization
	void Start () {
        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        if (finnished)
            return;

        //Tratado del cronometro
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

        //Si se tarda mas de 1 minuto,se reinicia el juego
        if (Time.time - startTime > 60)
        {
            Application.LoadLevel("scene_race_track");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel("scene_race_track");
        }
	
	}

    /*public void Inicio()
    {

        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }*/

    public void Finnish()
    {
        finnished = true;
        timerText.color = Color.red;

        /*timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            Application.LoadLevel("scene_race_track");
        }
        else
        {
            
            finishText.text= "Try again in ..." + (int)timeLeft;
        }*/
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel("scene_race_track");
    }

    
}
