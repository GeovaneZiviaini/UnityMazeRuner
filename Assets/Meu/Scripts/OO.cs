using UnityEngine;
using System.Collections;

public class OO : MonoBehaviour {

    float velocidadeMov;
    float velocidadeRot;
    
    

    public Vector3 vetor3;

	// Use this for initialization
	void Start () {
        //vetor3 = transform.position;

        velocidadeMov = 5.0f;
        velocidadeRot = 60.0f;

    }
	
	// Update is called once per frame
	void Update () {
        
        /*transform.position = vetor3;
           MOVE UM OBJETO
        */
       

        if (Input.GetButton("w")){

            transform.Translate(0,0,velocidadeMov * Time.deltaTime);


        }
        if (Input.GetButton("s"))
        {

            transform.Translate(0, 0, - velocidadeMov * Time.deltaTime);


        }
        if (Input.GetButton("s"))
        {

            transform.Translate(0, 0, -velocidadeMov * Time.deltaTime);


        }
        if (Input.GetButton("a"))
        {

            transform.Rotate(0, -velocidadeRot* Time.deltaTime,0 );


        }
        if (Input.GetButton("d"))
        {

            transform.Rotate(0, velocidadeRot * Time.deltaTime, 0);


        }
        if (Input.GetButton("q"))
        {

            transform.Rotate(velocidadeRot*Time.deltaTime, 0,0);


        }
        if (Input.GetButton("e"))
        {

            transform.Rotate( -velocidadeRot * Time.deltaTime, 0,0);


        }
    }
}
