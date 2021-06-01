using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;


public class BallScript : MonoBehaviour
{
    Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = GetComponent<Transform>();
        gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.cyan;
    }

    // Update is called once per frame
    void Update()
    {
        if ((trans.position.z > -0.456) && (trans.position.z < 0.462) && (trans.position.x < -60))
        {
            gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.red;
        }   
    }
}
