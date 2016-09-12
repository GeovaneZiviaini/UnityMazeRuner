using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ai : MonoBehaviour {

    public static Transform Player;
    public float velocidade;
    public float vlRot;
    public float tempo = 0f;
    public float cor;
    float sorte;
    public GameObject arma1;
    public GameObject arma2;
    public GameObject Key;
    private enum inimigoStatus {
        standard = 0,
        seguindo = 1,
        atacando = 2,
        morto = 3
    }

    private inimigoStatus estadoAtual;


    // Use this for initialization
    void Start() {
        estadoAtual = new inimigoStatus();
        cor = Random.value * 100;

        if (cor > 25 && cor < 50) {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        } else if (cor > 50 && cor < 70) {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        } else {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }


        Player = GameObject.FindGameObjectWithTag("Player").transform;

        if (velocidade <= 0) {
            velocidade = 6f;
        }


    }
    void controlerDaDistancia() {
        float distanciaPlayer = Vector3.Distance(transform.position, Player.position);

        if (distanciaPlayer <= 40) {
            estadoAtual = inimigoStatus.seguindo;
        } else if (distanciaPlayer >= 60) {
            estadoAtual = inimigoStatus.standard;
        } else if (distanciaPlayer <= 20) {
            estadoAtual = inimigoStatus.atacando;
        }

        switch (estadoAtual) {
            case inimigoStatus.atacando:
                velocidade = +10f;
                break;
            case inimigoStatus.seguindo:
                Vector3 Direcao = (Player.position - transform.position).normalized;
                transform.position += Direcao * Time.deltaTime * velocidade;
                Quaternion olhar = Quaternion.LookRotation(Direcao);
                transform.rotation = olhar;
                break;
            case inimigoStatus.standard:
                transform.Translate(0, 0, velocidade * Time.deltaTime);
                tempo = tempo + 1 * Time.deltaTime;
                if (tempo > 3) {
                    vlRot = 360 * Random.value;
                    transform.Rotate(0, vlRot, 0);
                    tempo = 0;
                }
                break;
        }
    }


    // Update is called once per frame
    void Update() {
        controlerDaDistancia();

        if (BarraDeVida.countVida == 0) {
            Application.LoadLevel("CenaDeMorte");

        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Bala") {
            Spaw.conMaxInim = Spaw.conMaxInim - 1;
            sorte = Random.value;

            if (sorte >= 0.5f) {
                Instantiate(arma1, transform.position, transform.rotation);

            } else {
                Instantiate(arma2, transform.position, transform.rotation);

            }
            if (sorte > 0.6 && sorte < 0.8) {
                Instantiate(Key, transform.position, transform.rotation);

            }

            Destroy(gameObject);

        }
    }


}
