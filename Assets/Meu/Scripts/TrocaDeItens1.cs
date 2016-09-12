using UnityEngine;
using System.Collections;

public class TrocaDeItens1 : MonoBehaviour
{

    GameObject ItensHeroiAux;


    string tipoItemAux;


    public Texture texturaItemAux;


    int contItensAux;


    string nomeItensAux;

    GameObject itemAtual;
    public TextMesh numeroDeitens;

    public static int indice;
    public Transform posArm;


    

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

            if (GUI.Button(new Rect(posicaoX, posicaoY, largura, altura), Iventario.texturaItens[count]))
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
                    ItensHeroiAux = Iventario.itensHeroi[indiceCliqueInic];
                    Iventario.itensHeroi[indiceCliqueFinal] = ItensHeroiAux;

                    nomeItensAux = Iventario.nomeItens[indiceCliqueInic];
                    Iventario.nomeItens[indiceCliqueInic] = Iventario.nomeItens[indiceCliqueFinal];
                    Iventario.nomeItens[indiceCliqueFinal] = nomeItensAux;

                    tipoItemAux = Iventario.tipoItens[indiceCliqueInic];
                    Iventario.tipoItens[indiceCliqueInic] = Iventario.tipoItens[indiceCliqueFinal];
                    Iventario.tipoItens[indiceCliqueFinal] = tipoItemAux;

                    contItensAux = Iventario.countItens[indiceCliqueInic];
                    Iventario.countItens[indiceCliqueInic] = Iventario.countItens[indiceCliqueFinal];
                    Iventario.countItens[indiceCliqueFinal] = contItensAux;

                    texturaItemAux = Iventario.texturaItens[indiceCliqueInic];
                    Iventario.texturaItens[indiceCliqueInic] = Iventario.texturaItens[indiceCliqueFinal];
                    Iventario.texturaItens[indiceCliqueFinal] = texturaItemAux;

                    fazTroca = false;
                    indiceCliqueFinal = -1;
                }

            }

        }
    }
   
}
