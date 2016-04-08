using UnityEngine;
using System.Collections;

public class Inicio : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Car").SendMessage("Inicio");
    }
}
