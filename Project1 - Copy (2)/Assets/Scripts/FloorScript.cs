using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngline.Color;

public class FloorScript : MonoBehaviour
{
    //Transformation trans;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().materials[0].color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
