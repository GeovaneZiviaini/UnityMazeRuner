using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;
public class Pause : MonoBehaviour
{
    public static bool controlePause;
    public static bool trava;
    string NameSave;
    string nomeSave;
    Vector3 posicao;
    Salvar observar;

    public GUISkin texButton;
    private Transform Player;

    public Font MyFont;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        controlePause = true;
        observar = gameObject.AddComponent<Salvar>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }


        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (controlePause)
            {
                trava = true;
                controlePause = false;
                Time.timeScale = 0;
                Iventario.atira = false;
                GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                trava = false;
                Time.timeScale = 1;
                controlePause = true;
                Iventario.atira = true;
                GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = true;

            }
        }

    }
    void OnGUI()
    {
        GUI.skin.font = MyFont;
        GUI.skin = texButton;
        if (!controlePause)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), " ");

            bool salvarJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 70, 100, 20), "Salvar Jogo");

            bool menu = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 90, 100, 20), "Menu Principal");
            bool load = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 110, 100, 20), "Load");
            bool sair = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 130, 100, 20), "Sair");


           /* if (salvarJogo)
            {
                NameSave = Salvar.VerificarSave();

                Salvar.SalvaPos(nomeSave, Player.position);

            }
            */
            if (menu)
            {
                Application.LoadLevel("MenuPrincipal");


            }
          /*  if (load)
            {
                Application.LoadLevel("SaveAndLoad");

            }
            */
            if (sair)
            {
                Application.Quit();

            }
        }
    }
}
