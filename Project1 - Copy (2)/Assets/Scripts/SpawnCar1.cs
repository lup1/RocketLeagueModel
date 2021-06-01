using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class SpawnCar1 : MonoBehaviour
{
    public Transform AIcarTeam1;
    public Transform AIcarTeam2;
    // Start is called before the first frame update
   System.Random rnd = new System.Random();
    public int carNum = 8;


    void Start()
    {
        
        for (int i = 2; i < carNum; i++)
        {
            Instantiate(AIcarTeam1, new Vector3((float)rnd.Next(0, 60), 1, (float)rnd.Next(-35 ,40)), Quaternion.identity);
            
            
        }
        for (int i = 1; i < carNum; i++)
        {
            Instantiate(AIcarTeam2, new Vector3((float)rnd.Next(-60, 0), 1, (float)rnd.Next(-35, 40)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
