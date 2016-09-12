using UnityEngine;
using System.Collections;

public class BarraDeVida : MonoBehaviour
{

    public GUISkin texButton;
    float posX;
    float posY;
    float altura;
    float largura;
    public static float countVida;
    float maxVida;
    float tempo;

    // Use this for initialization

    void Start()
    {
        countVida = 100;
        maxVida = 100;
        tempo = 1;

    }

    // Update is called once per frame
    void Update()
    {
        tempo = tempo + Time.deltaTime;

        posX = Screen.width / 1000;
        posY = Screen.height / 4 - Screen.height / 4;
        altura = Screen.height / 6;
        largura = Screen.width / 4 * (countVida / maxVida);





        if (countVida > maxVida)
        {
            countVida = countVida - 1;

        }


        if (tempo >= 0)
        {
            if (countVida < 100)
            {
                if (tempo > 5.5f)
                {
                    countVida = countVida + 5;
                    tempo = 0;
                }
            }
        }



    }
    void OnGUI()
    {
        GUI.skin = texButton;




        GUI.Button(new Rect(posX, posY, largura, altura), " ");
    }
}
