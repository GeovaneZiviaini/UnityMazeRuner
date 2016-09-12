using UnityEngine;
using System.Collections;

public class ExemploDesi : MonoBehaviour {

    public bool activation = false;
    public string forpaint = "O sistema está : ";




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (activation)
        {
            string status = "Ativado";

            Debug.Log(forpaint + status);

        }else 
        {
            string status = "Desastivado";
            Debug.LogError(forpaint + status);
        }


	
	}
}
