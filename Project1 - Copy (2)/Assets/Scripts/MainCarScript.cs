using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCarScript : MonoBehaviour
{
    Transform trans;
    Vector3 startPosition;  // To set start position
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.GetComponent<Transform>();
        startPosition = trans.position; // Captures start position for respawn
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKey(KeyCode.W))
        {

            trans.Translate(0.0f, 0.0f, Time.deltaTime * 15.0f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            trans.Rotate(0.0f, Time.deltaTime * -100.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddForce(trans.forward * -1.0f);
            trans.Translate(0.0f, 0.0f, Time.deltaTime * -15.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            trans.Rotate(0.0f, Time.deltaTime * 100.0f, 0.0f);
        }
        if (Input.GetButton("Fire2"))
        {
            trans.Rotate(5.0f, 0.0f, 0.0f); // Maybe make this smaller so that the jump isn't a whole flip
        }

        // Fell off the side/into the goal

        if (trans.position.y < -5)  // Car is out LOL
        {
            trans.position = startPosition;   // Puts car back without moving ball
        }
    }
}
