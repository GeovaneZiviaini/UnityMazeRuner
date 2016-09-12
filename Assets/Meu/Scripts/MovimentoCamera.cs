using UnityEngine;
using System.Collections;

public class MovimentoCamera : MonoBehaviour {
   

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
     
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)|| Input.GetMouseButton(2))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            Vector3 cameraPos = new Vector3(-mouseX, 0, -mouseY);
            GetComponent<Camera>().transform.position += cameraPos;
        }
   
    }
}
