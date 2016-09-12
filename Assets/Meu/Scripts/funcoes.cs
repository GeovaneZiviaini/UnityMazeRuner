using UnityEngine;
using System.Collections;

public class funcoes : MonoBehaviour {
  //função void "sem parametro"

        void falaOi()
    {
        print("Oi!");
    }

    void falaQueEuteEscuto(string fala)
    {
        string txt = fala;

        print(txt);
    }

    void operacao(string z, float x, float y)
    {
        if(z == "adicao")
        {
            float resposta = x + y;
            print(resposta);

        }else if (z == "subtracao")
        {
            float resposta = x - y;
            print(resposta);
        }
        else
        {
           Debug.LogError("O comando não é valido ");
        }

        
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        operacao("troll",45.6f,85.2f);
	}
}
