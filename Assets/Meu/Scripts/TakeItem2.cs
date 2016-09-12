using UnityEngine;
using System.Collections;

public class TakeItem2 : MonoBehaviour
{
    public GameObject novaArma;
    public GameObject Armas;
    public static string nomeArma2;
    int contador;
    bool existI;
    string tipo;
    public static int countMuni;
    public Texture texturaArma2;
    int indiceVazio;

    // Use this for initialization
    void Start()
    {
        tipo = "Automatica";
        nomeArma2 = "Metralhadora";
        countMuni = 20;
       
    }
    void rot()
    {

        GameObject[] Arma2 = GameObject.FindGameObjectsWithTag("Arma2");

        foreach (GameObject novaArma in Arma2)
        {

            novaArma.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
           
        }
    }
    void Rotacao()
    {
        Armas.transform.Rotate(0, 45 * Time.deltaTime, 0);

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
        if (col.gameObject.tag == "Arma2")
        {
            while (contador < Iventario.maxIndice)
            {
                if (nomeArma2 == Iventario.nomeArmas[contador])
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
                Iventario.nomeArmas[indiceVazio] = nomeArma2;
                Iventario.countMuni[indiceVazio] = countMuni;
                Iventario.texturaArma[indiceVazio] = texturaArma2;
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
