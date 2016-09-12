using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections.Generic;

public  class AbrirTorre : MonoBehaviour
{

    private GUIStyle guiStyle = new GUIStyle();
    public Font MyFont;
    public float DistanciaMinima = 2, DistanciaMaxima = 6;
    private float DistanciaAjustada;
    private Vector3 PontoFinalDoRaio;
    public Transform Key;
    public static bool podeMovimentar;
    private GameObject Jogador;
    private float sensX;
    private float sensY;
    private GameObject referenciaTemporaria;
    private bool estaMovimentando;
    public Texture chave;
    public Texture cadeado;




    /* private enum trinco
     {
         preta = 0,
         marrom = 1,
         amarela = 2
     }

         private trinco key;
     */

    // Use this for initialization
    void Start()
    {


        DistanciaAjustada = (DistanciaMinima + DistanciaMaxima) / 2;

        Cursor.visible = false;

        Jogador = GameObject.FindWithTag("Player");
        sensX = Jogador.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity;
        sensY = Jogador.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity;

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit PontoDeColisao;
        Physics.Raycast(transform.position, transform.forward, out PontoDeColisao, 100);
        PontoFinalDoRaio = transform.position + transform.forward * DistanciaAjustada;
        if (Vector3.Distance(transform.position, PontoDeColisao.point) <= DistanciaMaxima && PontoDeColisao.transform.gameObject.tag == "Porta")
        {
            podeMovimentar = true;
        }
        else
        {
            podeMovimentar = false;
        }

        if (Input.GetMouseButtonDown(0) && podeMovimentar == true)
        {

            DistanciaAjustada = Vector3.Distance(transform.position, PontoDeColisao.point);
            referenciaTemporaria = PontoDeColisao.transform.gameObject;


        }
    }

    /*Esboso
     * void Fechadura()
     {
         key = new trinco();

         float sort = Random.value * 100;
         if (sort <= 30)
         {
             key = trinco.preta;

         }
         else if (sort >= 33)
         {
             key = trinco.marrom;

         }
         else
         {
             key = trinco.amarela;
         }

     }
     */
    void OnGUI()

    {
        GUI.skin.font = MyFont;
        guiStyle.normal.textColor = Color.red;
        guiStyle.fontSize = 20;

        for (int i = 0; i <= Iventario.countItens.Length; i++)
        {
            if (Iventario.countItens[0] == 0 && podeMovimentar == true)
            {
                GUI.DrawTexture(new Rect(Screen.width / 2 - cadeado.width / 2, Screen.height / 2 - cadeado.height / 2, cadeado.width, cadeado.height), cadeado);

            }



            if (podeMovimentar == true && Iventario.countItens[0] >= 1)
            {
                GUI.DrawTexture(new Rect(Screen.width / 2 - chave.width / 2, Screen.height / 2 - chave.height / 2, chave.width, chave.height), chave);
                GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 50, 100, 20), "[ E ]", guiStyle);
            }

        }


    }
}






