using UnityEngine;
using System.Collections;

public class Colisao : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Municao")
        {
            Destroy(col.gameObject);

        }
    }
}
