using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private CubeOController CubeOControllerScript;


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

        //destroy growPoints when they collide with the player, or barriers when they match the player's color, and bounce if otherwise
        if (gameObject.tag == "GrowPoint")
        {
            Destroy(gameObject);
            CubeOControllerScript.cubeOScore++;
            CubeOControllerScript.cubeOSize++;
            Debug.Log("Your score is " + CubeOControllerScript.cubeOScore);
            
        } else if(gameObject.tag == other.gameObject.tag)
        {
            Destroy(gameObject);
            CubeOControllerScript.setCubeORandomColor();
        } else if(other.gameObject.transform.position.z < gameObject.transform.position.z && CubeOControllerScript.gameLevel > 0)

        {
                other.gameObject.transform.Translate(Vector3.forward * -0.5f);

        } else if (CubeOControllerScript.gameLevel > 0)
        {
                other.gameObject.transform.Translate(Vector3.forward * 0.5f);
        }


    }

}
