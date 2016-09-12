using UnityEngine;
using System.Collections;

public class bala2 : MonoBehaviour
{
    float velocidadeBala;


    void Start()
    {

    }

    void Update()
    {
        velocidadeBala = 60 * Time.deltaTime;
        transform.Translate(0, 0, velocidadeBala);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
            Destroy(gameObject);
        }
    }
}