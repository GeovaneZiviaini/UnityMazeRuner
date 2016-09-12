using UnityEngine;
using System.Collections;

public class trocaArmas : MonoBehaviour
{

    GameObject armasHeroiAux;


    string tipoArmasAux;


    public Texture texturaArmaAux;


    int contMunicaoArmaAux;


    string nomeArmasAux;

    GameObject armaAtual;
    public TextMesh municao;

    public static int indice;
    public Transform posArm;


    public static bool atira;

    int QDTItensMenu;
    int recuoX;
    int recuoY;
    float posicaoX;
    float posicaoY;
    float altura;
    float largura;
    int count;
    private bool fazTroca;
    int indiceCliqueInic;
    int indiceCliqueFinal;

    void OnGUI()
    {
        count = 0;
        while (count < 10)
        {

            altura = Screen.height / 10;
            largura = Screen.width / 10;
            recuoY = (int)altura + 10;
            posicaoX = largura * count + recuoX;
            posicaoY = Screen.height - recuoY;

            if (GUI.Button(new Rect(posicaoX, posicaoY, largura, altura), Iventario.texturaArma[count]))
            {
                if (fazTroca == false)
                {
                    indiceCliqueInic = count;
                    fazTroca = !fazTroca;
                }
                else
                {
                    indiceCliqueFinal = count;
                }

                if (fazTroca == true && indiceCliqueFinal != -1)
                {
                    armasHeroiAux = Iventario.armasHeroi[indiceCliqueInic];
                    Iventario.armasHeroi[indiceCliqueFinal] = armasHeroiAux;

                    nomeArmasAux = Iventario.nomeArmas[indiceCliqueInic];
                    Iventario.nomeArmas[indiceCliqueInic] = Iventario.nomeArmas[indiceCliqueFinal];
                    Iventario.nomeArmas[indiceCliqueFinal] = nomeArmasAux;

                    tipoArmasAux = Iventario.tipoArma[indiceCliqueInic];
                    Iventario.tipoArma[indiceCliqueInic] = Iventario.tipoArma[indiceCliqueFinal];
                    Iventario.tipoArma[indiceCliqueFinal] = tipoArmasAux;

                    contMunicaoArmaAux = Iventario.countMuni[indiceCliqueInic];
                    Iventario.countMuni[indiceCliqueInic] = Iventario.countMuni[indiceCliqueFinal];
                    Iventario.countMuni[indiceCliqueFinal] = contMunicaoArmaAux;

                    texturaArmaAux = Iventario.texturaArma[indiceCliqueInic];
                    Iventario.texturaArma[indiceCliqueInic] = Iventario.texturaArma[indiceCliqueFinal];
                    Iventario.texturaArma[indiceCliqueFinal] = texturaArmaAux;

                    fazTroca = false;
                    indiceCliqueFinal = -1;
                }

            }

        }
    }


}
