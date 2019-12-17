using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : Bolt.EntityBehaviour<IPlayerState>
{
    public Camera cam = null;
    public GameObject infoCanvas;

    public override void Attached()
    {
        if (entity.IsOwner)
        {
            cam.enabled = true;
            cam.gameObject.SetActive(true);
            //infoCanvas.GetComponent<Canvas>().renderCamera = 
        }
        //state.PlayerTransform.SetTransforms(transform);
        state.SetTransforms(state.PlayerTransform, transform);
    }

    public override void SimulateOwner()
    {

        // var speed = 4f;
        // var movement = Vector3.zero;

        // if (Input.GetKey(KeyCode.UpArrow)) { movement.z += 1; }
        // if (Input.GetKey(KeyCode.DownArrow)) { movement.z -= 1; }
        // if (Input.GetKey(KeyCode.LeftArrow)) { movement.x -= 1; }
        // if (Input.GetKey(KeyCode.RightArrow)) { movement.x += 1; }

        // if (movement != Vector3.zero)
        // {
        //     transform.position = transform.position + (movement.normalized * speed * BoltNetwork.FrameDeltaTime);
        // }
    }
}
