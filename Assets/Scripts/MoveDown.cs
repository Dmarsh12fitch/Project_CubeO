using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private CubeOController CubeOControllerScript;

    private float speed = 3.5f;


    // Start is called before the first frame update
    void Start()
    {
        CubeOControllerScript = GameObject.Find("CubeO").GetComponent<CubeOController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
