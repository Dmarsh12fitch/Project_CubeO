using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    private CubeOController CubeOControllerScript;

    private float startWaitTime = 1;
    private float spawnInterval = 2;
    

    public GameObject[] longBarrierPrefabs;

    public GameObject growPointPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CubeOControllerScript = GameObject.Find("CubeO").GetComponent<CubeOController>();

        InvokeRepeating("spawnObstaclesAndGrowPoints", startWaitTime, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObstaclesAndGrowPoints()
    {
        if (CubeOControllerScript.gameLevel == 1)
        {
            int randSelection = Random.Range(0, 4);
            if (randSelection == 0)
            {
                levelOneA();
            }
            else if (randSelection == 1)
            {
                levelOneB();
            }
            else if (randSelection == 2)
            {
                levelOneC();
            }
            else
            {
                levelOneD();
            }
        } else if(CubeOControllerScript.gameLevel == 2)
        {
            Debug.Log("                         START SPAWNING IN LEVEL 2 OBSTACLE GROUPINGS");
        }


    }


    //level one groupings
    void levelOneA()
    {
        int randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if(spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(-1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
    }

    void levelOneB()
    {
        int randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
    }

    void levelOneC()
    {
        int randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(-3, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
    }

    void levelOneD()
    {
        int randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        randomLongBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomLongBarrier], spawnPosition, longBarrierPrefabs[randomLongBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(3, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
    }



    //level two groupings
    void levelTwoA()
    {

    }

}
