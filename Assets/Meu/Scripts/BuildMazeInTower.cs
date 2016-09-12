using UnityEngine;
using System.Collections;

public class BuildMazeInTower : MonoBehaviour
{

    public Transform muroPosA;
    public Transform muroPosB;
    public Transform muroPosC;
    public Transform muro;

    public Transform portao;
    public Transform portaoPosA;
    public Transform portaoPosB;
    public Transform portaoPosC;
    public Transform portaoComChave;

    public Transform spaw;

    public GameObject inimigo;
    float tempo;


    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma3;
    public GameObject hp;
    public GameObject key;

    public static int conMaxInim;


    // Use this for initialization
    void Start()
    {
        BuildWall();
        PosIten();
    }

    // Update is called once per frame
    void Update()
    {
        Spaw();
    }
    /*Este metodo é responsavel por moldar o labirinto, ele instacia as parades e portas
     * de forma aleatória 
     */
    void BuildWall()
    {
        float pos = Random.value;
        if (pos > 0.5)

        {
            Instantiate(muro, transform.position + (muroPosA.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(portao, transform.position + (portaoPosC.position - transform.position), Quaternion.Euler(-90f, 0f, 90f));
        }
        else if (pos > 0.2 && pos < 0.4)
        {
            Instantiate(portaoComChave, transform.position + (portaoPosA.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(muro, transform.position + (muroPosC.position - transform.position), Quaternion.Euler(-90f, 0f, 90f));
        }

    }

    // Este metodo é responsvele pela posicao dos Inimigos no mapa
    void Spaw()
    {
        float pos = Random.value;
        tempo = tempo + 1 * Time.deltaTime;
        if (conMaxInim < 1 && tempo > 5f)
        {
            if (pos >= 0.1)
            {
                Instantiate(inimigo, transform.position + (spaw.position - transform.position), Quaternion.Euler(0f, 45f, 0f));

            }
            conMaxInim = conMaxInim + 1;
            tempo = 0;
        }
    }

    // Este metodo é responsavel pela posição dos itens no mapa
    void PosIten()
    {
        float sorte = Random.value;

        if (sorte >= 0.61f && sorte <= 0.71)
        {
            Instantiate(arma1, transform.position + (spaw.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(key, transform.position + (spaw.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));

        }

        if (sorte >= 0.11 && sorte <= 0.15)
        {
            Instantiate(hp, transform.position + (spaw.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(arma3, transform.position + (spaw.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(arma2, transform.position + (spaw.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));

        }
    }
}
