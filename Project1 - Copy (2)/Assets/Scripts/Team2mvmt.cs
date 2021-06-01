using System.Collections;
using System.Collections.Generic;
//using System.Media;
//using System.Media;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Team2mvmt : MonoBehaviour
{
    public GameObject SoccerBall;
    public Transform AItransformTeam2;
    public Vector3 startPos2;
    // Start is called before the first frame update
    void Start()
    {
        startPos2 = AItransformTeam2.position;
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = Quaternion.LookRotation(SoccerBall.transform.position - transform.position);
        AItransformTeam2.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.05f);
        AItransformTeam2.transform.position = Vector3.MoveTowards(transform.position, SoccerBall.transform.position, 0.05f);
    }
}
