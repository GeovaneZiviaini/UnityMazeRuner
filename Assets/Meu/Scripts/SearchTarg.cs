using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SearchTargs : MonoBehaviour
{
    private Transform Player;

   

    private List<GameObject> wayPointsList;



    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;

      
        wayPointsList = new List<GameObject>();

        GameObject[] wayPoint = GameObject.FindGameObjectsWithTag("wayPoint");
        

        Player.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;


        foreach (GameObject newWayPoint in wayPoint)
        {
            wayPointsList.Add(newWayPoint);

        }
     
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
    }
    void Follow()
    {
        GameObject wayPoint = null;
      

        if (Physics.Linecast(transform.position, Player.position))
        {
            wayPoint = FindBetterWay();
        }
        else
        {
            wayPoint = GameObject.FindGameObjectWithTag("Player");
        }

        Vector3 Dir = (wayPoint.transform.position - transform.position).normalized;
        transform.position += Dir * Time.deltaTime * 5;
        transform.rotation = Quaternion.LookRotation(Dir);


    }
    GameObject FindBetterWay()
    {
        GameObject betterWay = null;
        float distanceToBetterWay = Mathf.Infinity;

        foreach (GameObject go in wayPointsList)
        {
            float disToWayPoint = Vector3.Distance(transform.position, go.transform.position);
            float distWayPointToTarget = Vector3.Distance(go.transform.position, Player.position);
            float disToTarget = Vector3.Distance(transform.position, Player.position);

            bool wallBetween = Physics.Linecast(transform.position, go.transform.position);

            if ((disToWayPoint < distanceToBetterWay) && (disToTarget > distWayPointToTarget) && (!wallBetween))
            {

                distanceToBetterWay = disToWayPoint;
                betterWay = go;
            }
            else
            {
                bool wayPointToTargetCollision = Physics.Linecast(go.transform.position, Player.position);
                if (!wayPointToTargetCollision)
                {
                    betterWay = go;

                }

            }

        }

        return betterWay;

    }
}
