using System.Collections;
using UnityEngine;

public class Salvar : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

  

    // Update is called once per frame
    void Update()
    {

    }
    public static string VerificarSave()
    {
        string s;
        if (PlayerPrefs.GetInt("Save1") == 1)
        {
            s = "Save1";

        }
        if (PlayerPrefs.GetInt("Save2") == 1)
        {
            s = "Save2";


        }
        if (PlayerPrefs.GetInt("Save3") == 1)
        {
            s = "Save3";

        }
        return ("s");


    }
    public static void SalvaPos(string nomeSave, Vector3 posicao)
    {
        PlayerPrefs.SetFloat(nomeSave + "pX", posicao.x);
        PlayerPrefs.SetFloat(nomeSave + "pY", posicao.y);
        PlayerPrefs.SetFloat(nomeSave + "pZ", posicao.z);
    }
    public static Vector3 CarregaPos(string nomeSave)
    {
        Vector3 poicao;

        poicao.x = PlayerPrefs.GetFloat(nomeSave + "pX");
        poicao.y = PlayerPrefs.GetFloat(nomeSave + "pY");
        poicao.z = PlayerPrefs.GetFloat(nomeSave + "pZ");

        return (poicao);
    }
}
