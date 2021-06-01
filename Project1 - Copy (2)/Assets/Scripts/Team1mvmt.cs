using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Team1mvmt : MonoBehaviour
{
    public GameObject SoccerBall;
    public Transform AItransformTeam1;
    public Vector3 startPos1;
    // Start is called before the first frame update
    void Start()
    {
        startPos1 = AItransformTeam1.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        Quaternion rotation = Quaternion.LookRotation(SoccerBall.transform.position - transform.position);
        AItransformTeam1.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 0.05f);
        AItransformTeam1.transform.position = Vector3.MoveTowards(transform.position, SoccerBall.transform.position, 0.05f);
        
    }
}
