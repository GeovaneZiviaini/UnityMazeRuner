using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PegarItenschao : MonoBehaviour
{


    public GameObject novoIten;
    public static string nomeItem;

    int contador;
    bool existI;
    public static string tipo;
    public Texture texturaDoItem;
    int indiceVazio;
    public static int countItens;

    public
    // Use this for initialization
    void Start()
    {
        tipo = "Chave";
        nomeItem = "Chave de Ouro";
        countItens = 1 ;

        //nomeIten.Add("Chave de prata");
        //nomeIten.Add("Chave de Madeira");

    }



    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        contador = 0;
        existI = false;
        indiceVazio = -1;



        if (col.gameObject.tag == "Item")
        {
            while (contador < Iventario.maxIndice)
            {
                if (nomeItem == Iventario.nomeItens[contador] || nomeItem == InventarioGeral.nomeItens[contador])
                {
                    existI = true;
                    break;
                }
                if (Iventario.nomeItens[contador] == "Vazio" && indiceVazio == -1)
                {
                    indiceVazio = contador;
                }
                contador = contador + 1;
            }
            if (existI == false)
            {
                Iventario.itensHeroi[indiceVazio] = novoIten;
                Iventario.nomeItens[indiceVazio] = nomeItem;
                Iventario.texturaItens[indiceVazio] = texturaDoItem;
                Iventario.tipoItens[indiceVazio] = tipo;
                Iventario.countItens[indiceVazio] = countItens;
                //Iventario.indice = Iventario.indice + 1;
                Destroy(col.gameObject);
            }
            else
            {
                Iventario.countItens[contador] = Iventario.countItens[contador] + countItens;
                Destroy(col.gameObject);
            }
        }

    }
}
