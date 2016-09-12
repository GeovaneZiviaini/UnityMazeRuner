using UnityEngine;
using System.Collections;

public class Spaw : MonoBehaviour
{
    public GameObject inimigo;
    public static int conMaxInim;
    private Transform Player;
    public Transform iten;
    public Vector3 posInim;
    float tempo;
    // Use this for initialization
    void Start()
    {
        conMaxInim = 0;
        tempo = 0f;
       iten = GameObject.FindGameObjectWithTag("Spaw").transform;

    }
    // Update is called once per frame
    void Update()
    {
        tempo = tempo + 1 * Time.deltaTime;
        if (conMaxInim < 200 && tempo > 30f)
        {
            if (Random.value> 0.5) {
                posInim.x = iten.position.x + (Random.value * 10) + 10;
            }
            else
            {
                posInim.x = iten.position.x - (Random.value * 10) + 10;
            }
            if (Random.value > 0.5)
            {
                posInim.z = iten.position.z + (Random.value * 10) + 10;
            }
            else
            {
                posInim.z = iten.position.z - (Random.value * 10) + 10;
            }
            posInim.y = iten.position.y + 10;
           

            Instantiate(inimigo, posInim, transform.rotation);
            conMaxInim = conMaxInim + 1;

            tempo = 0;
        }
    }
}
