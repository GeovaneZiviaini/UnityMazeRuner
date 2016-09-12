using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class UserInterFace : MonoBehaviour
{

    public GUISkin skin;
    public string nome;
    public GUISkin texButton;
    public Font MyFont;
    void Start()
    {

    }
    void OnGUI()
    {
        GUI.skin = skin;
        GUI.skin.font = MyFont;
        GUI.skin = texButton;

        bool NovoJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 20), "Novo Jogo");


        bool CarregarJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 70, 100, 20), "Carregar Jogo");

        bool Cancelar = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 90, 100, 20), "Sair");


        if (NovoJogo)
        {
            Application.LoadLevel("TesteMapa01");


        }

        if (CarregarJogo)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "Essa opção ainda não foi desenvolvida");

        }

        if (Cancelar)
        {
            Application.Quit();
        }



    }

    void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


}
