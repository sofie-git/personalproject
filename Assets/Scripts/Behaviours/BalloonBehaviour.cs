using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBehaviour : Bolt.EntityBehaviour<IBalloonState>
{

    public GameObject ballon;

    void Awake()
    {
        ballon = GameObject.Find("/balloon/ballon");
    }
    public override void Attached()
    {

        state.SetTransforms(state.BalloonTransform, transform);

        state.BalloonColor = new Color(Random.value, Random.value, Random.value);
        state.AddCallback("BalloonColor", ColorChanged);
    }

    public override void SimulateOwner()
    {

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

    void ColorChanged()
    {
        ballon.GetComponent<Renderer>().material.color = state.BalloonColor;
    }

}
