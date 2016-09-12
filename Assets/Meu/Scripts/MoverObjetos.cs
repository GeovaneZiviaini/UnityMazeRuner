using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
public class MoverObjetos : MonoBehaviour
{
    public float DistanciaMinima = 2, DistanciaMaxima = 6;
    public float VelocidadeDeMovimento = 10, velocidadeDeRotacao = 50;
    public float ForcaParaAtirar = 3000;
    public Texture MaoFechada, MaoAberta;
    private bool podeMovimentar, estaMovimentando;
    private float DistanciaAjustada;
    private Vector3 PontoFinalDoRaio;
    private Vector3 velocity = Vector3.zero;
    private GameObject referenciaTemporaria, Jogador;
    private float sensX, sensY;
    
    void Start()
    {
        DistanciaAjustada = (DistanciaMinima + DistanciaMaxima) / 2;
        Cursor.visible = false;
        Jogador = GameObject.FindWithTag("Player");
        sensX = Jogador.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity;
        sensY = Jogador.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity;
    }
    void Update()
    {
        RaycastHit PontoDeColisao;
        Physics.Raycast(transform.position, transform.forward, out PontoDeColisao, 100);
        PontoFinalDoRaio = transform.position + transform.forward * DistanciaAjustada;
        if (Vector3.Distance(transform.position, PontoDeColisao.point) <= DistanciaMaxima && PontoDeColisao.transform.gameObject.tag == "OBJETO")
        {
            podeMovimentar = true;
        }
        else
        {
            podeMovimentar = false;
        }
        if (Input.GetMouseButtonDown(0) && podeMovimentar == true)
        {
            DistanciaAjustada = Vector3.Distance(transform.position, PontoDeColisao.point);
            PontoDeColisao.rigidbody.useGravity = false;
            referenciaTemporaria = PontoDeColisao.transform.gameObject;
            estaMovimentando = true;
        }
        if (Input.GetMouseButtonUp(0) && referenciaTemporaria != null)
        {
            referenciaTemporaria.GetComponent<Rigidbody>().useGravity = true;
            referenciaTemporaria = null;
            Jogador.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = sensX;
            Jogador.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = sensY;
            estaMovimentando = false;
        }
        if (Input.GetMouseButtonDown(1) && referenciaTemporaria != null)
        {
            Vector3 direcao = PontoFinalDoRaio - transform.position;
            referenciaTemporaria.GetComponent<Rigidbody>().useGravity = true;
            referenciaTemporaria.GetComponent<Rigidbody>().AddForce(direcao * ForcaParaAtirar * (Time.deltaTime * 1000));
            referenciaTemporaria = null;
            estaMovimentando = false;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            DistanciaAjustada--;
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            DistanciaAjustada++;
        }
        if (DistanciaAjustada < DistanciaMinima)
        {
            DistanciaAjustada = DistanciaMinima;
        }
        if (DistanciaAjustada > DistanciaMaxima)
        {
            DistanciaAjustada = DistanciaMaxima;
        }
        if (referenciaTemporaria != null)
        {
            //ROTACIONAR OBJETOS
            if (Input.GetKey(KeyCode.R))
            {
                Jogador.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = 0;
                Jogador.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = 0;
                referenciaTemporaria.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
                float rotationX = Input.GetAxis("Mouse X") * velocidadeDeRotacao / 10;
                float rotationY = Input.GetAxis("Mouse Y") * velocidadeDeRotacao / 10;
                referenciaTemporaria.transform.RotateAroundLocal(Camera.main.transform.up, -Mathf.Deg2Rad * rotationX);
                referenciaTemporaria.transform.RotateAroundLocal(Camera.main.transform.right, Mathf.Deg2Rad * rotationY);
            }
            if (Input.GetKeyUp(KeyCode.R))
            {
                Jogador.GetComponent<FirstPersonController>().m_MouseLook.XSensitivity = sensX;
                Jogador.GetComponent<FirstPersonController>().m_MouseLook.YSensitivity = sensY;
            }
        }
    }
    void FixedUpdate()
    {
        if (referenciaTemporaria != null)
        {
            referenciaTemporaria.GetComponent<Rigidbody>().position = Vector3.SmoothDamp(referenciaTemporaria.transform.position, PontoFinalDoRaio, ref velocity, (100 / VelocidadeDeMovimento) * Time.deltaTime);
        }
    }
    void OnGUI()
    {
        if (podeMovimentar == true && estaMovimentando == false)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - MaoAberta.width / 2, Screen.height / 2 - MaoAberta.height / 2, MaoAberta.width, MaoAberta.height), MaoAberta);
        }
        if (estaMovimentando == true)
        {
            GUI.DrawTexture(new Rect(Screen.width / 2 - MaoFechada.width / 2, Screen.height / 2 - MaoFechada.height / 2, MaoFechada.width, MaoFechada.height), MaoFechada);
        }
    }
}

