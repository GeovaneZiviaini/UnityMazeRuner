using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class GameOver : MonoBehaviour
{

    public Font MyFont;
    public GUISkin skin;

    void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }


    void OnGUI()
    {
        GUI.skin.font = MyFont;
        Cursor.lockState = CursorLockMode.Confined;
        bool NovoJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 20), "Novo Jogo");
        bool Menu = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 70, 100, 20), "Menu Princial");
        bool Sair = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 90, 100, 20), "Sair");


        if (Menu)
        {
            Application.LoadLevel("MenuPrincipal");
        }
        if (NovoJogo)
        {
            Application.LoadLevel("TesteMapa01");
          
            Time.timeScale = 1;
        }
        if (Sair)
        {
            Application.Quit();
        }

    }



}

