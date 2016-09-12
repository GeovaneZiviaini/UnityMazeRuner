using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class TelaSave : MonoBehaviour
{

    public string heroi;
    public string heroi2;
    public string heroi3;
    bool carregarJogo;
    bool carregarJogo2;
    bool carregarJogo3;

    // Use this for initialization
    void Start()
    {

        heroi = PlayerPrefs.GetString("Heroi1");
        heroi2 = PlayerPrefs.GetString("Heroi2");
        heroi3 = PlayerPrefs.GetString("Heroi3");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {

        /*carregarJogo = GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + -122, 100, 20), "Carregar Jogo1");
        carregarJogo2 = GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + -82, 100, 20), "Carregar Jogo2");
        carregarJogo3 = GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + -42, 100, 20), "Carregar Jogo3");
        */
       // bool Deletar = GUI.Button(new Rect(Screen.width / 2 - 170, Screen.height / 2 + 50, 100, 20), "Del All");
        bool voltar = GUI.Button(new Rect(Screen.width / 2 - 30, Screen.height / 2 + 50, 100, 20), "Voltar");

        //heroi = GUI.TextArea(new Rect(Screen.width / 2 - 170, Screen.height / 2 - 122, 100, 20), heroi);

        /*if (carregarJogo)
        {
            if (heroi == PlayerPrefs.GetString("Heroi1"))
            {
                PlayerPrefs.SetInt("NovoSave", 0);
            }
            else
            {
                PlayerPrefs.SetInt("NovoSave", 1);
            }
            PlayerPrefs.SetString("Heroi1", heroi);
            PlayerPrefs.SetInt("Save1", 1);
            PlayerPrefs.SetInt("Save2", 0);
            PlayerPrefs.SetInt("Save3", 0);
            Application.LoadLevel("ISSOAI");
            Time.timeScale = 1;
            Pause.controlePause = true;
            Iventario.atira = true;
            


        }

        heroi2 = GUI.TextArea(new Rect(Screen.width / 2 - 170, Screen.height / 2 - 82, 100, 20), heroi2);
        if (carregarJogo2)
        {
            if (heroi2 == PlayerPrefs.GetString("Heroi2"))
            {
                PlayerPrefs.SetInt("NovoSave", 0);
            }
            else
            {
                PlayerPrefs.SetInt("NovoSave", 1);
            }

            PlayerPrefs.SetString("Heroi2", heroi2);
            PlayerPrefs.SetInt("Save1", 0);
            PlayerPrefs.SetInt("Save2", 1);
            PlayerPrefs.SetInt("Save3", 0);
            Application.LoadLevel("ISSOAI");
            Time.timeScale = 1;
            Pause.controlePause = true;
            Iventario.atira = true;
           


        }
        heroi3 = GUI.TextArea(new Rect(Screen.width / 2 - 170, Screen.height / 2 - 42, 100, 20), heroi3);
        if (carregarJogo3)
        {
            if (heroi3 == PlayerPrefs.GetString("Heroi3"))
            {
                PlayerPrefs.SetInt("NovoSave", 0);
            }
            else
            {
                PlayerPrefs.SetInt("NovoSave", 1);
            }
            PlayerPrefs.SetString("Heroi2", heroi3);
            PlayerPrefs.SetInt("Save1", 0);
            PlayerPrefs.SetInt("Save2", 0);
            PlayerPrefs.SetInt("Save3", 1);
            Time.timeScale = 1;
            Pause.controlePause = true;
            Iventario.atira = true;
     
            Application.LoadLevel("ISSOAI");
        }
        
        if (Deletar)
        {
            BancoDeDados.deletarJogosSalvos();
            Application.LoadLevel("SaveAndLoad");
        }
        */
        if (voltar)
        {
            Application.LoadLevel("MenuPrincipal");
        }
    }
}
