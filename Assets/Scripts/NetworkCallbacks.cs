using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    public override void SceneLoadLocalDone(string map)
    {
        // randomize a position
        //var spawnPositionServer = new Vector3(Random.Range(-8, 8), 2, Random.Range(-8, 8));
        var spawnPosition = new Vector3(Random.Range(-10, 10), 9, Random.Range(-10, 10));


        //Debug.Log(Camera.allCameras.Length);
        BoltNetwork.Instantiate(BoltPrefabs.Balloonpilot, spawnPosition, Quaternion.identity);



    }
}
