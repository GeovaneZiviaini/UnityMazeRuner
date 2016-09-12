using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{
    public string myName;
    public string idade;
 
    void OnGui()
    {
        myName = GUI.TextField(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 20), myName);
        idade = GUI.TextField(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 20, 100, 20), idade);

        bool salvarJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 20), "Salvar Jogo");

        bool CarregarJogo = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 70, 100, 20), "Carregar Jogo");
        bool Deletar = GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 90, 100, 20), "Deletar Jogo");

        if (salvarJogo)
        {
            BancoDeDados.salvarDados(myName, idade);
        }
        if (CarregarJogo)
        {
            string[] valoresRetornados = BancoDeDados.carregarDados();
            myName = valoresRetornados[0];
            idade = valoresRetornados[1];
        }
        if (Deletar)
        {
            BancoDeDados.deletarJogosSalvos();

        }
    }
}

