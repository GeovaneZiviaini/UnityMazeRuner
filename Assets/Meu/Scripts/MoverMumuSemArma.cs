using UnityEngine;
using System.Collections;

public class MoverMumuSemArma : MonoBehaviour
{
    public Animator Weaponless;
    private enum MumyStatus
    {
        idle = 0,
        seguindo = 1,
        atacando = 2,
        morto = 3,
        corrento = 4
    }
    float sorte;
    public GameObject arma1;
    public GameObject arma2;
    public GameObject Key;

    public float DistanciaMinima = 2, DistanciaMaxima = 6;
    private float DistanciaAjustada;
    private Vector3 PontoFinalDoRaio;

    private bool estaMovimentando;

    public static Transform Player;
    private MumyStatus estadoAtual;

    public float velocidade;
    public float vlRot;

    public float tempo = 0f;
    private bool podeMovimentar;
    private GameObject Inimigo;

    void controlerAcoes()
    {
        float distanciaPlayer = Vector3.Distance(transform.position, Player.position);

        if (distanciaPlayer > 3 && distanciaPlayer <= 25)
        {
            estadoAtual = MumyStatus.seguindo;
        }
        else if (distanciaPlayer >= 30)
        {
            estadoAtual = MumyStatus.idle;
        }
        else if (distanciaPlayer > 1 && distanciaPlayer <=3)
        {
            estadoAtual = MumyStatus.atacando;
        }

        switch (estadoAtual)
        {
            case MumyStatus.atacando:
                Weaponless.SetBool("Atack", true);
                break;
            case MumyStatus.seguindo:
                Weaponless.SetBool("Run", true);
                Vector3 Direcao = (Player.position - transform.position).normalized;
                transform.position += Direcao * Time.deltaTime * velocidade;

                Quaternion olhar = Quaternion.LookRotation(Direcao);
                transform.rotation = olhar;

                break;
            case MumyStatus.idle:
                Weaponless.SetBool("Walk", true);
                transform.Translate(0, 0, velocidade * Time.deltaTime);
                tempo = tempo + 1 * Time.deltaTime;
                if (tempo > 5)
                {
                    vlRot = 360 * Random.value;
                    transform.Rotate(0, vlRot, 0);
                    tempo = 0;

                }
                // olhar para outro lado caso encontre uma parede
                if (podeMovimentar == true && DistanciaMinima <= 50)
                {
                    var lado = Random.value;
                    Quaternion olha = Quaternion.Euler(0, 90f, 0f);
                    Quaternion olhae = Quaternion.Euler(0, -90f, 0f);
                    if (lado <= 0.5)
                    {
                        transform.rotation = olha;
                    }
                    else
                    {
                        transform.rotation = olhae;
                    }

                }
                // caso olhe para o chao


                break;
        }
    }
    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        estadoAtual = new MumyStatus();
        tempo = 0f;
        if (velocidade <= 0f)
        {
            velocidade = 6f;
        }

        DistanciaAjustada = (DistanciaMinima + DistanciaMaxima) / 2;



        Inimigo = GameObject.FindWithTag("Inimigo");


    }


    // Update is called once per frame
    void Update()
    {
        controlerAcoes();
        if (BarraDeVida.countVida == 0)
        {
            Application.LoadLevel("CenaDeMorte");

        }

        RaycastHit PontoDeColisao;
        Physics.Raycast(transform.position, transform.forward, out PontoDeColisao, 100);
        PontoFinalDoRaio = transform.position + transform.forward * DistanciaAjustada;
        if (Vector3.Distance(transform.position, PontoDeColisao.point) <= DistanciaMaxima && PontoDeColisao.transform.gameObject.tag == "Muro"
            || Vector3.Distance(transform.position, PontoDeColisao.point) <= DistanciaMaxima && PontoDeColisao.transform.gameObject.tag == "Chao")
        {
            podeMovimentar = true;
        }
        else
        {
            podeMovimentar = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Bala")
        {
            Spaw.conMaxInim = Spaw.conMaxInim - 1;
            sorte = Random.value;

            if (sorte >= 0.5f)
            {
                Instantiate(arma1, transform.position, transform.rotation);

            }
            else
            {
                Instantiate(arma2, transform.position, transform.rotation);

            }
            if (sorte > 0.6 && sorte < 0.8)
            {
                Instantiate(Key, transform.position, transform.rotation);

            }

            Destroy(gameObject);

        }
        if (col.gameObject.tag == "chao")
        {
            Quaternion.Euler(0f, 45f, 0f);
        }

    }
}
