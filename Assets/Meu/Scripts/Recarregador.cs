using UnityEngine;
using System.Collections;

public class Recarregador : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Municao")
        {
            Takeitem.countMuni = Takeitem.countMuni = +10;

            Destroy(col.gameObject);
        }
    }


}