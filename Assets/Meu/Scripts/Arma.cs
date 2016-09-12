using UnityEngine;
using System.Collections;


public class Arma : MonoBehaviour
{
    public  GameObject projetil;
    bool trava;
    public static int contMunicao;

    public bool HasFound { get; internal set; }

    // Use this for initialization
    void Start()
    {

        trava = true;
    }

    // Update is called once per frame
    void Update()
    {


        if (Pause.trava == false)
        {
            if (Iventario.atira == true)
            {
                Instantiate(projetil, transform.position, transform.rotation);
                Iventario.atira = false;
            }
            else if(Pause.trava == true)
            {
                Iventario.atira = false;
            }
        }
    }
}

