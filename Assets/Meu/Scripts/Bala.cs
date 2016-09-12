using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {
    float velocidadeBala;
  
    // Use this for initialization
    void Start () {

       
	}
	
	// Update is called once per frame
	void Update () {
        velocidadeBala = 60f * Time.deltaTime;
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
