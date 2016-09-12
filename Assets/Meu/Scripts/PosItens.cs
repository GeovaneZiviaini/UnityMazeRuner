using UnityEngine;
using System.Collections;

public class PosItens : MonoBehaviour
{
    public GameObject inimigo;
    float tempo;
    public Transform iten;
    public Transform marcador;
    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 100f;
    public GameObject arma1;
    public GameObject arma2;
    public GameObject arma3;
    public GameObject hp;
    public static int conMaxInim;
    public GameObject key;

    // Use this for initialization
    void Start()
    {
        conMaxInim = 0;
        tempo = 0f;

        Sorteio();

        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {

                Vector3 pos = new Vector3(x, 1, y) * spacing;

                Instantiate(marcador, pos, Quaternion.Euler(-90, 0f, 0f));

            }

        }

    }

    void Sorteio()
    {
        

    }

    void Spaw()
    {

     
    }
    // Update is called once per frame
    void Update()
    {
        Spaw();
    }
}
