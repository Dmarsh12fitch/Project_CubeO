using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOController : MonoBehaviour
{
    public int gameLevel = 1;       //-1 is in between, 0 is game over, and 1,2,3 are levels
    public int levelsComplete = 0;
    public float inBetweenLevelTimeLeft = 6.0f;

    public float horizontalInput;
    public float verticalInput;
    private float speed = 9;

    private Vector3 startCubeOScale;
    private Vector3 smallCubeOScale;
    private Vector3 sMCubeOScale;
    private Vector3 mediumCubeOScale;
    private Vector3 mLCubeOScale;
    private Vector3 largeCubeOScale;
    public int cubeOSize = 1;

    public int cubeOScore = 0;
    public Material[] allCubeOColors;
    public string[] allCubeOColorStrings;
    public Material currentColorCubeO;
    public MeshRenderer meshRendererCubeO;
    private int previousRandColorIndex = -1;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        startCubeOScale = new Vector3(0.5f, 0.5f, 0.5f);
        smallCubeOScale = new Vector3(0.625f, 0.625f, 0.625f);
        sMCubeOScale = new Vector3(0.6875f, 0.6875f, 0.6875f);
        mediumCubeOScale = new Vector3(0.75f, 0.75f, 0.75f);
        mLCubeOScale = new Vector3(0.875f, 0.875f, 0.875f);
        largeCubeOScale = new Vector3(1, 1, 1);

        meshRendererCubeO = GetComponent<MeshRenderer>();
        currentColorCubeO = meshRendererCubeO.material;
        gameObject.tag = allCubeOColorStrings[0];

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cubeOSize == 3)
        {
            transform.localScale = startCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.25f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize == 6)
        {
            transform.localScale = smallCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.3125f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize == 9)
        {
            transform.localScale = sMCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.34375f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize == 12)
        {
            transform.localScale = mediumCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.375f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize == 15)
        {
            transform.localScale = mLCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.4375f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize == 18)
        {
            transform.localScale = largeCubeOScale;
            transform.localPosition = new Vector3(transform.position.x, 0.5f, transform.position.z);
            cubeOSize++;
        } else if (cubeOSize >= 21)
        {
            cubeOSize = 1;
            levelsComplete++;
            gameLevel = -1;
            transform.localScale = startCubeOScale;
            transform.localPosition = new Vector3(0, 0.25f, -4);
            rb.velocity = new Vector3(0, rb.velocity.y, 0);
            Debug.Log("                                   LEVEL " + levelsComplete + " COMPLETE!");
        }
        


        if (gameLevel > 0)
        {

            //horizontal movement
            horizontalInput = Input.GetAxis("Horizontal");
            //vertical movement
            verticalInput = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(horizontalInput, rb.velocity.y, verticalInput) * speed;

            //game over if out of bounds
            if (transform.position.y < -0.5 || transform.position.z > 5 || transform.position.z < -5.25f)
            {
                Debug.Log("GAME OVER GAME OVER GAME OVER");
                gameLevel = 0;
                Destroy(gameObject);
            }
        } else if(gameLevel == -1)
        {
            inBetweenLevelTimeLeft -= Time.deltaTime;
            if(inBetweenLevelTimeLeft < 0)
            {
                gameLevel = levelsComplete + 1;
                inBetweenLevelTimeLeft = 6;
                Debug.Log("                                   LEVEL " + gameLevel + "!");
            }
        }

    }

    public void setCubeORandomColor()
    {
        int randColorIndex = Random.Range(0, allCubeOColors.Length);
        while (randColorIndex == previousRandColorIndex)
        {
            randColorIndex = Random.Range(0, allCubeOColors.Length);
        }
        meshRendererCubeO.material = allCubeOColors[randColorIndex];
        gameObject.tag = allCubeOColorStrings[randColorIndex];
        previousRandColorIndex = randColorIndex;
    }


}
