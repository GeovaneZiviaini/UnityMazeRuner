using UnityEngine;
using System.Collections;

public class Heroi : MonoBehaviour
{


    public string nomeHeroi = null;
    string NomeSave = null;


    string nomeSave = null;
    private Transform Player;

    // Use this for initialization
    void Start()
    {
     /*   Player = GameObject.FindGameObjectWithTag("Player").transform;


        if (PlayerPrefs.GetInt("Save1") == 1)
        {
            nomeHeroi = PlayerPrefs.GetString("Heroi1");
        }
        else if (PlayerPrefs.GetInt("Save2") == 1)
        {
            nomeHeroi = PlayerPrefs.GetString("Heroi2");
        }
        else if (PlayerPrefs.GetInt("Save3") == 1)
        {
            nomeHeroi = PlayerPrefs.GetString("Heroi3");
        }

        if (PlayerPrefs.GetInt("NovoSave") == 0)
        {
            transform.position = Salvar.CarregaPos(NomeSave);
        }
        else
        {

        }
        */
    }



    // Update is called once per frame
    void Update()
    {



    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
            if (BarraDeVida.countVida > 0)
            {
                BarraDeVida.countVida = BarraDeVida.countVida - 15;
                GetComponent<AudioSource>().Play();

            }

        }
    }
}
