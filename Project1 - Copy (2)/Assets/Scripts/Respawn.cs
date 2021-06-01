using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform trans;
    public int YellowScore;
    public int BlueScore;

    public GameObject AIcarTeam2;

    //public Transform Team2mvmt;

    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.GetComponent<Transform>();
        YellowScore = 0;
        BlueScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (trans.position.x < -60 && trans.position.z > -0.5 && trans.position.z < 0.5 && trans.position.y < 0.5)  // Ball in goal
        if (trans.position.x < -60 && trans.position.y < 0.5)
        {
            //YellowScore++;
            UnityEngine.Debug.Log("Yellow scores!");
            //AIcarTeam2.transform.position = AIcarTeam2.Team2mvmt.startPos2;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // Reloads scene
            
            
        }

        //if (trans.position.x > 60 && trans.position.z > -0.5 && trans.position.z < 0.5 && trans.position.y < 0.5)  // Ball in goal
        if (trans.position.x > 60 && trans.position.y < 0.5)
        {
            //BlueScore++;
            UnityEngine.Debug.Log("Blue scores!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // Reloads scene
            
        }
        //UnityEngine.Debug.Log("Yellow: " + YellowScore + " Blue: " + BlueScore);
    }
}
