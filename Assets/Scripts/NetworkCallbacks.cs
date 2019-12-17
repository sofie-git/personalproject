using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    public override void SceneLoadLocalDone(string map)
    {

        if (BoltNetwork.IsServer) {
            // var spawnPosition = new Vector3(Random.Range(-10, 10), 1, Random.Range(-10, 10));
            var spawnPosition = new Vector3(0, 1, 0);
            BoltNetwork.Instantiate(BoltPrefabs.Player, spawnPosition, Quaternion.identity);

        } else if (BoltNetwork.IsClient) {
            var spawnPosition = new Vector3(Random.Range(-10, 10), 9, Random.Range(-10, 10));
            BoltNetwork.Instantiate(BoltPrefabs.Balloonpilot, spawnPosition, Quaternion.identity);
        }

    }
}
