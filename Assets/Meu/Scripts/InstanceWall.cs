using UnityEngine;
using System.Collections;

public class InstanceWall : MonoBehaviour
{
    public Transform brick;

    public Transform muroPosA;
    public Transform muroPosB;
    public Transform muroPosC;
    public Transform muroPosD;
    public Transform muro;
    public Transform portao;

    public Transform portaoPosA;
    public Transform portaoPosB;
    public Transform portaoPosC;

    public Transform portaoComChave;

    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 100f;


    void Start()
    {
        

        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {
             
                Vector3 pos = new Vector3(x, 0, y) * spacing;

                PosMuro();
                Instantiate(brick, pos, Quaternion.Euler(-90, 0f, 0f));

            }

        }
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    void PosMuro()
    {
        float pos = Random.value;
        if (pos > 0.5)

        {
            Instantiate(muro, transform.position + (muroPosA.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(portao, transform.position + (portaoPosC.position - transform.position), Quaternion.Euler(-90f, 0f, 90f));
        }
        else if (pos > 0.2 && pos < 0.4)
        {
            Instantiate(portaoComChave, transform.position + (portaoPosA.position - transform.position), Quaternion.Euler(-90f, 0f, 0f));
            Instantiate(muro, transform.position + (muroPosC.position - transform.position), Quaternion.Euler(-90f, 0f, 90f));
        }
       
    }

}
