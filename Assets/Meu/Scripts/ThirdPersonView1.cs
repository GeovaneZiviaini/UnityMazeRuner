using UnityEngine;
using System.Collections;

public class ThirdPersonView1 : MonoBehaviour {

    public Transform cameraPos;
    public Transform Player;
    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Slerp(transform.position, 
            cameraPos.position,Time.deltaTime);
        transform.LookAt(Player);
    }
}
