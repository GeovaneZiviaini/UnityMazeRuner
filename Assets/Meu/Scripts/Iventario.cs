using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Iventario : MonoBehaviour
{

    public static GameObject[] armasHeroi;
    GameObject armasHeroiAux;

    public static GameObject[] itensHeroi;
    GameObject itensHeroiAux;


    public static string[] tipoArma;
    string tipoArmasAux;

    public static string[] tipoItens;
    string tipoItensAux;

    public static Texture[] texturaArma;
    public Texture texturaArmaAux;

    public static Texture[] texturaItens;
    public Texture texturaItensAux;

    public static int[] countItens;
    int countItensAux;


    public static int[] countMuni;
    int contMunicaoArmaAux;

    public static string[] nomeArmas;
    string nomeArmasAux;



    public static string[] nomeItens;
    string nomeItensAux;

    public static GameObject armaAtual;
    public static GameObject ItenAtual;

    public TextMesh numeroDeItens;
    public TextMesh municao;

    public static int changeGun = 0;
    public static int indice;
    public static int maxIndice;
    public static int indiceClique;

    public Transform posArm;
    public Transform posItens;

    bool trava;
    public static bool atira;
    public static bool usar;

    int QDTItensMenu;
    int recuoX;
    int recuoY;
    float posicaoX;
    float posicaoY;
    float altura;
    float largura;
    int count;

    public static bool fazTroca;
    public static int indiceCliqueInic;
    int indiceCliqueFinal;
    string muni;
    private GUIStyle guiStyle = new GUIStyle();
    public Font MyFont;

    void OnGUI()
    {
        GUI.skin.font = MyFont;
        guiStyle.normal.textColor = Color.red;
        guiStyle.fontSize = 20;

        for (int i = 0; i <= tipoArma.Length;i++)
        {
            if (i.Equals("Lamina"))
            {
                GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 100, 100, 20), "Espada".ToUpper(), guiStyle);
            }
        }
    

        if (tipoItens[0] == "Chave")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 10, 100, 20), "Chave de Ouro: ".ToUpper() + countItens[0], guiStyle);
        }
        else if (tipoItens[1] == "Chave")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 10, 100, 20), "Chave de Ouro: ".ToUpper() + countItens[1], guiStyle);
        }

        else if (tipoItens[2] == "Chave")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 10, 100, 20), "Chave de Ouro".ToUpper() + countItens[2], guiStyle);
        }



        if (tipoArma[0] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[0], guiStyle);
        }
        else if (tipoArma[1] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[1], guiStyle);
        }

        else if (tipoArma[2] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[2], guiStyle);
        }
        else if (tipoArma[3] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[3], guiStyle);
        }
        else if (tipoArma[4] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[4], guiStyle);
        }
        else if (tipoArma[5] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[5], guiStyle);
        }
        else if (tipoArma[6] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[6], guiStyle);
        }
        else if (tipoArma[7] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[7], guiStyle);
        }
        else if (tipoArma[8] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[8], guiStyle);
        }
        else if (tipoArma[9] == "Automatica")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 70, 100, 20), "Metralhadora: ".ToUpper() + countMuni[9], guiStyle);
        }





        if (tipoArma[0] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[0], guiStyle);
        }
        else if (tipoArma[1] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[1], guiStyle);
        }
        else if (tipoArma[2] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[2], guiStyle);
        }
        else if (tipoArma[3] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[3], guiStyle);
        }
        else if (tipoArma[4] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[4], guiStyle);
        }
        else if (tipoArma[5] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[5], guiStyle);
        }
        else if (tipoArma[6] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[6], guiStyle);
        }
        else if (tipoArma[7] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[7], guiStyle);
        }
        else if (tipoArma[8] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[8], guiStyle);
        }
        else if (tipoArma[9] == "Pistola")
        {
            GUI.Label(new Rect(Screen.width / 100, Screen.height / 2 - 40, 100, 20), "Pistola: ".ToUpper() + countMuni[9], guiStyle);
        }


        count = 0;

        while (count < 10)
        {

            altura = Screen.height / 10;
            largura = Screen.width / 10;
            recuoY = (int)altura + 20;
            posicaoX = largura * count + recuoX;
            posicaoY = Screen.height - recuoY;

            if (GUI.Button(new Rect(posicaoX, posicaoY, largura, altura), texturaArma[count]))
            {

                if (fazTroca == false)
                {
                    indiceCliqueInic = count;
                    fazTroca = !fazTroca;
                    indiceClique = count;
                }
                else
                {
                    indiceCliqueFinal = count;
                }

                if (fazTroca == true && indiceCliqueFinal != -1)
                {
                    armasHeroiAux = armasHeroi[indiceCliqueInic];
                    armasHeroi[indiceCliqueInic] = armasHeroi[indiceCliqueFinal];
                    armasHeroi[indiceCliqueFinal] = armasHeroiAux;

                    nomeArmasAux = nomeArmas[indiceCliqueInic];
                    nomeArmas[indiceCliqueInic] = nomeArmas[indiceCliqueFinal];
                    nomeArmas[indiceCliqueFinal] = nomeArmasAux;

                    tipoArmasAux = tipoArma[indiceCliqueInic];
                    tipoArma[indiceCliqueInic] = tipoArma[indiceCliqueFinal];
                    tipoArma[indiceCliqueFinal] = tipoArmasAux;

                    contMunicaoArmaAux = countMuni[indiceCliqueInic];
                    countMuni[indiceCliqueInic] = countMuni[indiceCliqueFinal];
                    countMuni[indiceCliqueFinal] = contMunicaoArmaAux;

                    texturaArmaAux = texturaArma[indiceCliqueInic];
                    texturaArma[indiceCliqueInic] = texturaArma[indiceCliqueFinal];
                    texturaArma[indiceCliqueFinal] = texturaArmaAux;

                    fazTroca = false;
                    indiceCliqueFinal = -1;
                }

            }
            count = count + 1;
        }

        count = 0;
        while (count < 3)
        {
            altura = Screen.height / 10;
            largura = Screen.width / 10;
            recuoY = (int)altura + 100;
            posicaoX = largura * count + recuoX;
            posicaoY = Screen.height - recuoY;

            if (GUI.Button(new Rect(posicaoX, posicaoY, largura, altura), texturaItens[count]))
            {

                if (fazTroca == false)
                {
                    indiceCliqueInic = count;
                    fazTroca = !fazTroca;
                    indiceClique = count;
                }
                else
                {
                    indiceCliqueFinal = count;
                }

                if (fazTroca == true && indiceCliqueFinal != -1)
                {
                    itensHeroiAux = itensHeroi[indiceClique];
                    itensHeroi[indiceCliqueInic] = itensHeroi[indiceCliqueFinal];
                    itensHeroi[indiceCliqueFinal] = itensHeroiAux;

                    nomeItensAux = nomeItens[indiceClique];
                    nomeItens[indiceClique] = nomeItens[indiceCliqueFinal];
                    nomeItens[indiceCliqueFinal] = nomeItensAux;

                    tipoItensAux = tipoItens[indiceClique];
                    tipoItens[indiceCliqueInic] = tipoItens[indiceCliqueFinal];
                    tipoItens[indiceCliqueFinal] = tipoItensAux;

                    countItensAux = countItens[indiceCliqueInic];
                    countItens[indiceCliqueInic] = countItens[indiceCliqueFinal];
                    countItens[indiceCliqueFinal] = countItensAux;

                    texturaItensAux = texturaItens[indiceCliqueInic];
                    texturaItens[indiceCliqueInic] = texturaItens[indiceCliqueFinal];
                    texturaItens[indiceCliqueFinal] = texturaItensAux;


                    fazTroca = false;
                    indiceCliqueFinal = -1;
                }

            }
            count = count + 1;
        }

    }

    // Use this for initialization
    void Start()
    {
        armasHeroi = new GameObject[10];
        nomeArmas = new string[10];
        countMuni = new int[10];
        tipoArma = new string[10];
        texturaArma = new Texture[10];

        itensHeroi = new GameObject[10];
        nomeItens = new string[10];
        texturaItens = new Texture[10];
        countItens = new int[3];
        tipoItens = new string[10];

        QDTItensMenu = 10;
        indice = 0;
        maxIndice = 10;

        changeGun = 1;
        indiceClique = -1;
        for (count = 0; count < 10; count++)
        {
            nomeArmas[count] = "Vazio";
            nomeItens[count] = "Vazio";
        }


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("1") || indiceClique == 0)
        {


            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[0], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 1;
            indiceClique = -1;



        }
        if (Input.GetKeyDown("2") || indiceClique == 1)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[1], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 2;
            indiceClique = -1;


        }

        if (Input.GetKeyDown("3") || indiceClique == 2)
        {


            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[2], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 3;
            indiceClique = -1;

        }
        if (Input.GetKeyDown("4") || indiceClique == 3)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[3], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 4;
            indiceClique = -1;

        }
        if (Input.GetKeyDown("5") || indiceClique == 4)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[4], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 5;
            indiceClique = -1;


        }
        if (Input.GetKeyDown("6") || indiceClique == 5)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[5], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 6;
            indiceClique = -1;


        }
        if (Input.GetKeyDown("7") || indiceClique == 6)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[6], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 7;
            indiceClique = -1;



        }
        if (Input.GetKeyDown("8") || indiceClique == 7)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[7], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 7;
            indiceClique = -1;


        }
        if (Input.GetKeyDown("9") || indiceClique == 8)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[8], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 9;
            indiceClique = -1;
            ;
        }
        if (Input.GetKeyDown("-") || indiceClique == 9)
        {

            Destroy(armaAtual);
            armaAtual = (GameObject)Instantiate(armasHeroi[9], transform.position + (posArm.position - transform.position), transform.rotation);
            armaAtual.transform.parent = transform;
            changeGun = 10;
            indiceClique = -1;


        }



        if (Input.GetKeyDown("e") && AbrirTorre.podeMovimentar == true)
        {
            Destroy(ItenAtual);
            ItenAtual = (GameObject)Instantiate(itensHeroi[0], transform.position + (posItens.position - transform.position), transform.rotation);
            ItenAtual.transform.parent = transform;
            changeGun = 1;
            indiceClique = -1;



            if (countItens[0] <= 0)
            {
                Destroy(ItenAtual);
            }
        }
        if (Input.GetKeyDown("q") || indiceClique == 1)
        {


            Destroy(ItenAtual);
            ItenAtual = (GameObject)Instantiate(itensHeroi[1], transform.position + (posItens.position - transform.position), transform.rotation);
            ItenAtual.transform.parent = transform;
            changeGun = 2;
            indiceClique = -1;
        }

        if (Input.GetKeyDown("r") || indiceClique == 2)
        {
            Destroy(ItenAtual);
            ItenAtual = (GameObject)Instantiate(itensHeroi[2], transform.position + (posItens.position - transform.position), transform.rotation);
            ItenAtual.transform.parent = transform;
            changeGun = 3;
            indiceClique = -1;
        }



        if (tipoArma[changeGun - 1] == "Pistola")
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (countMuni[changeGun - 1] > 0)
                {

                    if (armaAtual)
                    {
                        if (Pause.trava == false)
                        {
                            atira = true;
                            countMuni[changeGun - 1] = countMuni[changeGun - 1] - 1;

                        }
                        else
                        {
                            atira = false;
                        }
                    }
                }

            }

        }
        if (tipoArma[changeGun - 1] == "Automatica")
        {

            if (Input.GetMouseButton(0))
            {

                if (countMuni[changeGun - 1] > 0)

                {
                    if (armaAtual)
                    {
                        if (Pause.trava == false)
                        {
                            atira = true;
                            countMuni[changeGun - 1] = countMuni[changeGun - 1] - 1;
                        }
                        else if (Pause.trava == true)
                        {
                            atira = false;
                        }

                    }
                }

            }
        }
        if (tipoArma[changeGun - 1] == "Lamina")
        {

        }
        if (tipoItens[changeGun - 1] == "Chave")
        {
            if (Input.GetKeyDown("e") && AbrirTorre.podeMovimentar == true)
            {
                if (countItens[changeGun - 1] > 0)
                {
                    countItens[changeGun - 1] = countItens[changeGun - 1] - 1;
                    GetComponent<AudioSource>().Play();
                }
            }


        }
    }
}


