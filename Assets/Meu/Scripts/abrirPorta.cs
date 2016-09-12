using UnityEngine;
using System.Collections;

public class abrirPorta : MonoBehaviour
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
        if (col.gameObject.tag == "Chave" && AbrirTorre.podeMovimentar == true)
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
      
        }
       
    }
}