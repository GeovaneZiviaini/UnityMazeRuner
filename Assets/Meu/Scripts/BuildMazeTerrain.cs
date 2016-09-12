using UnityEngine;
using System.Collections;

public class BuildMazeTerrain : MonoBehaviour
{
    public Transform brick;



    public float gridX = 5f;
    public float gridY = 5f;
    public float spacing = 100f;


    void Start()
    {
        MazeTowers();
    }

    // Update is called once per frame
    void Update()
    {

    }
    // esse metodo é responsavel pela criaçao da torres.
    void MazeTowers()
    {
        for (int y = 0; y < gridY; y++)
        {
            for (int x = 0; x < gridX; x++)
            {

                Vector3 pos = new Vector3(x, 0, y) * spacing;


                Instantiate(brick, pos, Quaternion.Euler(-90, 0f, 0f));

            }

        }

    }
}
