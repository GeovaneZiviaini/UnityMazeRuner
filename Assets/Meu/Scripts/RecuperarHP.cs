using UnityEngine;
using System.Collections;

public class RecuperarHP : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "HP")
        {
            BarraDeVida.countVida = BarraDeVida.countVida + 10;

            Destroy(col.gameObject);
        }
    }
}
