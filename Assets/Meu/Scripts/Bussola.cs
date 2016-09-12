using UnityEngine;
using System.Collections;

public class Bussola : MonoBehaviour {
    public Transform destino;
    public GameObject direcao;
    public float velocidade;
    public float vlRot;

    // Use this for initialization
    void Start() {
        destino = GameObject.FindGameObjectWithTag("Fim").transform;
    }

    // Update is called once per frame
    void Update() {

        Vector3 Direcao = (destino.position - transform.position).normalized;
        transform.position += Direcao * Time.deltaTime * vlRot;

        Quaternion olhar = Quaternion.LookRotation(Direcao);
        transform.rotation = olhar;
    }
}
