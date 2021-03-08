using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private CubeOController CubeOControllerScript;
    private bool done = false;


    // Start is called before the first frame update
    void Start()
    {
        CubeOControllerScript = GameObject.Find("CubeO").GetComponent<CubeOController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {

        //destroy growPoints when they collide with the player, or barriers when they match the player's color
        if (gameObject.tag == "GrowPoint" && !done)
        {
            done = true;
            CubeOControllerScript.cubeOScore++;
            CubeOControllerScript.cubeOSize++;
            Debug.Log("Your score is " + CubeOControllerScript.cubeOScore);
            Destroy(gameObject);
            

        } else if (gameObject.tag == "PointPill" && !done)
        {
            done = true;
            CubeOControllerScript.cubeOScore += 5;
            Debug.Log("Your score is " + CubeOControllerScript.cubeOScore);
            Destroy(gameObject);
        } else if(gameObject.tag == other.gameObject.tag)
        {
            Destroy(gameObject);
            CubeOControllerScript.setCubeORandomColor();
        }

    }

}
