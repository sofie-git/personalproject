using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{

    //public Transform SpawnPoint;
    public GameObject Balloon;

    //SpawnPoint.position = 

    void Start()
    {
        InvokeRepeating("CreateBalloon", 2, 2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacebar was pressed");
            //Instantiate(Balloon, SpawnPoint.position, SpawnPoint.rotation);
        }
    }

    // spawn a new balloon object on a random spawnpoint when pressing the spacebar
    public void CreateBalloon()
    {
        float x = Random.Range(-20.0f, 20.0f);
        float z = Random.Range(-20.0f, 20.0f);
        float y = Random.Range(8.0f, 15.0f);
        Instantiate(Balloon, new Vector3(x, y, z), Quaternion.identity);

    }
}
