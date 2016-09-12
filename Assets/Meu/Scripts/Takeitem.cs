using UnityEngine;
using System.Collections;

public class Takeitem : MonoBehaviour
{
    public GameObject Armas;
    public GameObject novaArma;
    public static string nomeArma;
    int contador;
    bool existI;
    public static int countMuni;
    string tipo;
    public Texture texturaArma1;
    int indiceVazio;
    // Use this for initialization
    void Start()
    {

        tipo = "Pistola";
        nomeArma = "Revolver";
        countMuni = 30;

    }
    void rot()
    {
        GameObject[] Arma1 = GameObject.FindGameObjectsWithTag("Arma");

        foreach (GameObject novomunicao in Arma1)
        {
            novomunicao.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;

        }

    }
    void Rotacao()
    {
        Armas.transform.Rotate(0, 45 * Time.deltaTime, 0);

    }
    // Update is called once per frame
    void Update()
    {
        Rotacao();
        rot();
    }

    void OnCollisionEnter(Collision col)
    {
        contador = 0;
        existI = false;
        indiceVazio = -1;
        if (col.gameObject.tag == "Arma")
        {
            while (contador < Iventario.maxIndice)
            {
                if (nomeArma == Iventario.nomeArmas[contador])
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
                Iventario.nomeArmas[indiceVazio] = nomeArma;
                Iventario.countMuni[indiceVazio] = countMuni;
                Iventario.texturaArma[indiceVazio] = texturaArma1;
                Iventario.tipoArma[indiceVazio] = tipo;
                
                Destroy(col.gameObject);
            }
            else
            {
                Iventario.countMuni[contador] = Iventario.countMuni[contador] + countMuni;
                Destroy(col.gameObject);
            }
        }
    }
}
