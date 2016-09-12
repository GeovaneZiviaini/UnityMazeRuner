using UnityEngine;
using System.Collections;

public class Tempo : MonoBehaviour {

    float tempo;
    float minuto;
    float segundo ;
    private GUIStyle guiStyle = new GUIStyle();
    public Font MyFont;
    // Use this for initialization
    void Start () {
	tempo = 0;
	}
	
	// Update is called once per frame
	void Update () {
        tempo = tempo + Time.deltaTime;
        
       
  

        if (tempo >= 60.0f)
        {
            minuto++;
            tempo = 0;
        }
        if (minuto == 15.0f)
        {
            Application.LoadLevel("CenaDeMorte");
        }

    }


    void OnGUI()
    {
        GUI.skin.font = MyFont;
       
        guiStyle.fontSize = 20;

        GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 130, 100, 20), minuto + " Min " + tempo + " Sec".ToUpper(), guiStyle);
        if (minuto >= 7.0f && minuto <= 10.0f)
        {
            guiStyle.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 130, 100, 20), minuto + " Min " + tempo + " Sec".ToUpper(), guiStyle);
        }else if (minuto >= 11.0 && minuto <= 15)
        {
            guiStyle.normal.textColor = Color.red;
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 130, 100, 20), minuto + " Min " + tempo + " Sec".ToUpper(), guiStyle);
        }

    }

    
       
        
    
}
