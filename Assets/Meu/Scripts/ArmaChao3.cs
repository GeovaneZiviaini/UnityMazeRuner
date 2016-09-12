using UnityEngine;
using System.Collections;

public class ArmaChao3 : MonoBehaviour
{

    public GameObject novaArma;
    public static string nomeArma3;
    int contador;
    bool existI;
    string tipo;
    public Texture texturaArma3;
    int indiceVazio;
    // Use this for initialization
    void Start()
    {
        tipo = "Lamina";
        nomeArma3 = "Esapada";
      
    }


    void rot()
    {
        GameObject[] Arma3 = GameObject.FindGameObjectsWithTag("Bala");
    }


    // Update is called once per frame
    void Update()
    {
        rot();
    }

    void OnCollisionEnter(Collision col)
    {
        contador = 0;
        existI = false;
        indiceVazio = -1;
        if (col.gameObject.tag == "Arma3")
        {
            while (contador < Iventario.maxIndice)
            {
                if (nomeArma3 == Iventario.nomeArmas[contador] || nomeArma3 == InventarioGeral.nomeArmas[contador])
                {
                    existI = true;
                    break;
                }
                if (Iventario.nomeArmas[contador] == "Vazio" && indiceVazio == -1)
                {
                    indiceVazio = contador;
                }
                contador = contador + 1;
            }
            if (existI == false)
            {
                Iventario.armasHeroi[indiceVazio] = novaArma;
                Iventario.nomeArmas[indiceVazio] = nomeArma3;
                Iventario.texturaArma[indiceVazio] = texturaArma3;
                Iventario.tipoArma[indiceVazio] = tipo;
                Destroy(col.gameObject);
            }

        }
    }
}
