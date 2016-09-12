using UnityEngine;
using System.Collections;

public class Elevacao : MonoBehaviour {
    private Animator ControleElevador;
    float tempo;
	// Use this for initialization
	void Start () {
        tempo = 0;
        ControleElevador = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if ( Input.GetKeyDown("e"))
        {
            ControleElevador.SetBool("playerOn", true);

        }
    }
   
}
