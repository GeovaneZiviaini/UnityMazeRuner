using UnityEngine;
using System.Collections;

public class DesBala : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bala")
        {
            Destroy(col.gameObject);
          
        }
    }
}
