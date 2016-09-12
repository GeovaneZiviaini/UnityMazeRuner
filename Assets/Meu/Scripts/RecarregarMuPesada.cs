using UnityEngine;
using System.Collections;

public class RecarregarMuPesada : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MunicaoPesada")
        {
            TakeItem2.countMuni = TakeItem2.countMuni = +10;

            Destroy(col.gameObject);
        }
    }
}
