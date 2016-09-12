using UnityEngine;
using System.Collections;

public class OFim : MonoBehaviour
{
    public Transform fim;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        fim.transform.Rotate(0, 45 * Time.deltaTime, 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Application.LoadLevel("MenuPrincipal");

         
        }
    }
}