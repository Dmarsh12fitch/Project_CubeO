using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    private CubeOController CubeOControllerScript;

    private float startWaitTime = 1;
    private float spawnInterval = 2;

    int randSelection;
    
    public GameObject[] longBarrierPrefabs;
    public GameObject[] tallBarrierPrefabs;

    public GameObject growPointPrefab;
    public GameObject pillPointPrefab;

    private bool rightUpWasLast = false;
    private bool leftUpWasLast = false;

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
            randSelection = Random.Range(0, 4);
            if (randSelection == 0)
            {
                levelOneA();
            } else if (randSelection == 1)
            {
                levelOneB();
            } else if (randSelection == 2)
            {
                levelOneC();
            } else
            {
                levelOneD();
            }
        }

        if(CubeOControllerScript.gameLevel == 2)
        {
            randSelection = Random.Range(0, 7);
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
            else if(randSelection == 3)
            {
                levelOneD();
            } else if (randSelection == 4)
            {
                levelTwoA();
            }else if (randSelection == 5)
            {
                levelTwoB();
            } else
            {
                levelTwoC();
            }
        }

        if(CubeOControllerScript.gameLevel == 3)
        {
            randSelection = Random.Range(0, 11);
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
            else if (randSelection == 3)
            {
                levelOneD();
            }
            else if (randSelection == 4)
            {
                levelTwoA();
            }
            else if (randSelection == 5)
            {
                levelTwoB();
            }
            else if (randSelection == 6)
            {
                levelTwoC();
            } else if (randSelection == 7)
            {
                levelThreeA();
            }
            else if (randSelection == 8)
            {
                levelThreeB();
            }
            else if (randSelection == 9)
            {
                levelThreeC();
            }
            else
            {
                levelThreeD();
            }
        }
    }


    //level one groupings
    void levelOneA()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if(spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(-1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    void levelOneB()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    void levelOneC()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(-3, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    void levelOneD()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(3, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    //level two groupings
    void levelTwoA()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(2.5f, 0.5f, 10);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(-0.4f, 0.5f, 10);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    void levelTwoB()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(0, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }

    void levelTwoC()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(-2.5f, 0.5f, 10);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(0.4f, 0.5f, 10);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnGrowPoint = Random.Range(0, 2);
        if (spawnGrowPoint == 1)
        {
            spawnPosition = new Vector3(-1, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = false;
    }







    //level three groupings
    void levelThreeA()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.7f, 0.5f, 10f);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.7f, 0.5f, 12.1f);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnPillPointOrGrowPoint = Random.Range(0, 3);
        if (spawnPillPointOrGrowPoint == 1)
        {
            spawnPosition = new Vector3(3.5f, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        } else if(spawnPillPointOrGrowPoint == 2)
        {
            spawnPosition = new Vector3(0.2f, 0.4f, 13);
            Instantiate(pillPointPrefab, spawnPosition, pillPointPrefab.transform.rotation);
        }
        leftUpWasLast = false;
        rightUpWasLast = true;
    }

    void levelThreeB()
    {
        int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(1.9f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
        spawnPosition = new Vector3(-0.2f, 0.5f, 10);
        Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.7f, 0.5f, 10);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
        spawnPosition = new Vector3(-1.7f, 0.5f, 12.1f);
        Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
        int spawnPillPointOrGrowPoint = Random.Range(0, 3);
        if (spawnPillPointOrGrowPoint == 1)
        {
            spawnPosition = new Vector3(-3.5f, 0.5f, 10);
            Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
        }
        else if (spawnPillPointOrGrowPoint == 2)
        {
            spawnPosition = new Vector3(-0.2f, 0.4f, 13);
            Instantiate(pillPointPrefab, spawnPosition, pillPointPrefab.transform.rotation);
        }
        leftUpWasLast = true;
        rightUpWasLast = false;
    }

    void levelThreeC()
    {
        if (!leftUpWasLast)
        {
            int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            Vector3 spawnPosition = new Vector3(4, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            spawnPosition = new Vector3(1.9f, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            spawnPosition = new Vector3(-0.2f, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
            spawnPosition = new Vector3(-1.7f, 0.5f, 10);
            Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
            spawnPosition = new Vector3(-1.7f, 0.5f, 7.9f);
            Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
            int spawnPillPointOrGrowPoint = Random.Range(0, 3);
            if (spawnPillPointOrGrowPoint == 1)
            {
                spawnPosition = new Vector3(-3.5f, 0.5f, 10);
                Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
            }
            else if (spawnPillPointOrGrowPoint == 2)
            {
                spawnPosition = new Vector3(-0.2f, 0.4f, 7);
                Instantiate(pillPointPrefab, spawnPosition, pillPointPrefab.transform.rotation);
            }
            leftUpWasLast = false;
            rightUpWasLast = false;
        } else
        {
            spawnObstaclesAndGrowPoints();
        }
    }

    void levelThreeD()
    {
        if (!rightUpWasLast)
        {
            int randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            Vector3 spawnPosition = new Vector3(-4, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            spawnPosition = new Vector3(-1.9f, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, longBarrierPrefabs.Length);
            spawnPosition = new Vector3(0.2f, 0.5f, 10);
            Instantiate(longBarrierPrefabs[randomBarrier], spawnPosition, longBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
            spawnPosition = new Vector3(1.7f, 0.5f, 10);
            Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
            randomBarrier = Random.Range(0, tallBarrierPrefabs.Length);
            spawnPosition = new Vector3(1.7f, 0.5f, 7.9f);
            Instantiate(tallBarrierPrefabs[randomBarrier], spawnPosition, tallBarrierPrefabs[randomBarrier].transform.rotation);
            int spawnPillPointOrGrowPoint = Random.Range(0, 3);
            if (spawnPillPointOrGrowPoint == 1)
            {
                spawnPosition = new Vector3(3.5f, 0.5f, 10);
                Instantiate(growPointPrefab, spawnPosition, growPointPrefab.transform.rotation);
            }
            else if (spawnPillPointOrGrowPoint == 2)
            {
                spawnPosition = new Vector3(0.2f, 0.4f, 7);
                Instantiate(pillPointPrefab, spawnPosition, pillPointPrefab.transform.rotation);
            }
            leftUpWasLast = false;
            rightUpWasLast = false;
        }
        else
        {
            spawnObstaclesAndGrowPoints();
        }
    }
    

}
