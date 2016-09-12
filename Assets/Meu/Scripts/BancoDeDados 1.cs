using UnityEngine;
using System.Collections;

public static class BancoDeDados  {

	public static void salvarDados(string myName,string idade)
    {

        string nm = myName;
        string i = idade;

        PlayerPrefs.SetString("myName",nm);
        PlayerPrefs.SetString("idade", i);
        Debug.Log(nm +", Seus dados foram salvos");
    }

    public static string[] carregarDados ()
    {
        string valor1 = PlayerPrefs.GetString("myName","");
        string valor2 = PlayerPrefs.GetString("idade", "");

        return new string[] {valor1,valor2 };
    }

    public static void deletarJogosSalvos()
    {
        PlayerPrefs.DeleteAll();
    }
}
