using UnityEngine;
using System.Collections;

public class InventarioGeral : MonoBehaviour
{

    public static GameObject[] armasHeroi;
    GameObject armasHeroiAux;

    public static GameObject[] itensHeroi;
    GameObject itensHeroiAux;

    public static string[] nomeItens;
    string nomeItensAux;

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

    int QDTItensMenu;
    int recuoX;
    int recuoY;
    float posicaoX;
    float posicaoY;
    float altura;
    float largura;
    int count;
    int multiplIndice;
    int indiceVaule;

    private bool fazTroca;
    int indiceCliqueInic;
    int indiceCliqueFinal;
    string muni;
    private GUIStyle guiStyle = new GUIStyle();
    public Font MyFont;


    // Use this for initialization
    void Start()
    {
        armasHeroi = new GameObject[100];
        nomeArmas = new string[100];
        countMuni = new int[100];
        tipoArma = new string[100];
        texturaArma = new Texture[100];

        itensHeroi = new GameObject[100];
        nomeItens = new string[100];
        texturaItens = new Texture[100];
        countItens = new int[100];
        tipoItens = new string[100];


        multiplIndice = 0;

        for (count = 0; count < 100; count++)
        {
            nomeArmas[count] = "Vazio";
            nomeItens[count] = "Vazio";
        }

    }
    void OnGUI()
    {
        if (Iventario.fazTroca)
        {
            count = 0;
            while (count < 9)
            {

                altura = 50;
                largura = Screen.width / 4;
                recuoY = (int)altura + ((int)altura * count);
                posicaoX = Screen.width - largura - 10;
                posicaoY = Screen.height / 2 + recuoY-345;
                indiceVaule = count + (10 * multiplIndice);

                if (GUI.Button(new Rect(posicaoX, posicaoY, largura, altura), (texturaArma[indiceVaule])))
                {
                    indiceCliqueFinal = count;

                    if (Iventario.fazTroca == true && indiceCliqueFinal != -1)
                    {
                        armasHeroiAux = Iventario.armasHeroi[Iventario.indiceCliqueInic];
                        Iventario.armasHeroi[Iventario.indiceCliqueInic] = armasHeroi[indiceCliqueFinal];
                        armasHeroi[indiceCliqueFinal] = armasHeroiAux;

                        itensHeroiAux = Iventario.itensHeroi[Iventario.indiceCliqueInic];
                        Iventario.itensHeroi[Iventario.indiceCliqueInic] = itensHeroi[indiceCliqueFinal];
                        itensHeroi[indiceCliqueFinal] = itensHeroiAux;

                        nomeItensAux = nomeItens[Iventario.indiceCliqueInic];
                        Iventario.nomeItens[Iventario.indiceCliqueInic] = nomeItens[indiceCliqueFinal];
                        nomeItens[indiceCliqueFinal] = nomeItensAux;

                        nomeArmasAux = nomeArmas[Iventario.indiceCliqueInic];
                        Iventario.nomeArmas[Iventario.indiceCliqueInic] = nomeArmas[indiceCliqueFinal];
                        nomeArmas[indiceCliqueFinal] = nomeArmasAux;

                        tipoArmasAux = Iventario.tipoArma[Iventario.indiceCliqueInic];
                        Iventario.tipoArma[Iventario.indiceCliqueInic] = tipoArma[indiceCliqueFinal];
                        tipoArma[indiceCliqueFinal] = tipoArmasAux;

                        tipoItensAux = Iventario.tipoItens[Iventario.indiceCliqueInic];
                        Iventario.tipoItens[Iventario.indiceCliqueInic] = tipoItens[indiceCliqueFinal];
                        tipoItens[indiceCliqueFinal] = tipoItensAux;

                        contMunicaoArmaAux = Iventario.countMuni[Iventario.indiceCliqueInic];
                        Iventario.countMuni[Iventario.indiceCliqueInic] = countMuni[indiceCliqueFinal];
                        countMuni[indiceCliqueFinal] = contMunicaoArmaAux;

                        countItensAux = Iventario.countItens[Iventario.indiceCliqueInic];
                        Iventario.countItens[Iventario.indiceCliqueInic] = countItens[indiceCliqueFinal];
                        countItens[indiceCliqueFinal] = countItensAux;

                        texturaArmaAux = Iventario.texturaArma[Iventario.indiceCliqueInic];
                        Iventario.texturaArma[Iventario.indiceCliqueInic] = texturaArma[indiceCliqueFinal];
                        texturaArma[indiceCliqueFinal] = texturaArmaAux;

                        texturaItensAux = Iventario.texturaItens[Iventario.indiceCliqueInic];
                        Iventario.texturaItens[Iventario.indiceCliqueInic] = texturaItens[indiceCliqueFinal];
                        texturaItens[indiceCliqueFinal] = texturaItensAux;

                        Iventario.fazTroca = false;
                        indiceCliqueFinal = -1;
                    }

                }



                count = count + 1;
            }
            posicaoY = posicaoY + 50;
            if (GUI.Button(new Rect(posicaoX, posicaoY, largura / 2, altura), "Avançar "))
            {
                if (multiplIndice < 9)
                {
                    multiplIndice++;
                }

            }
            if (GUI.Button(new Rect(posicaoX + largura / 2, posicaoY, largura / 2, altura), "Voltar "))
            {
                if (multiplIndice > 0)
                {
                    multiplIndice--;
                }

            }

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
