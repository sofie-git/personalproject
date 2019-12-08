using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : Bolt.EntityBehaviour<IPlayerState>
{
    public override void Attached()
    {
        Debug.Log("Ik zit in de Attached");
        //state.PlayerTransform.SetTransforms(transform);
        state.SetTransforms(state.PlayerTransform, transform);
    }

    public override void SimulateOwner()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed the spacebar in the player script");
        }

        var speed = 4f;
        var movement = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow)) { movement.z += 1; }
        if (Input.GetKey(KeyCode.DownArrow)) { movement.z -= 1; }
        if (Input.GetKey(KeyCode.LeftArrow)) { movement.x -= 1; }
        if (Input.GetKey(KeyCode.RightArrow)) { movement.x += 1; }

        if (movement != Vector3.zero)
        {
            transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        }
    }
}
