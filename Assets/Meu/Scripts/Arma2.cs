using UnityEngine;
using System.Collections;

public class Arma2 : MonoBehaviour
{

    public GameObject projetil;
    public static int contMunicao;
    bool trava;

    // Use this for initialization
    void Start()
    {

        trava = true;


    }

    // Update is called once per frame
    void Update()
    {

        trava = Input.GetMouseButtonDown(0);
        if (Pause.trava == false)
        {
            if (Iventario.atira == true)
            {
                Instantiate(projetil, transform.position, transform.rotation);
                Iventario.atira = false;
            }
            else if (Pause.trava == true)
            {
                Iventario.atira = false;
            }


        }
    }

}


