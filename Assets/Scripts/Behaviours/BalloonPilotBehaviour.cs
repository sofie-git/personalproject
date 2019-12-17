using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPilotBehaviour : Bolt.EntityBehaviour<IBalloonState>
{

    public float moveSpeed = 3f;
    private bool moveForward = false;
    public GameObject ballon;

    public Camera cam = null;
    public override void Attached()
    {
        state.SetTransforms(state.BalloonTransform, transform);
        //
        //state.BalloonColor = new Color(Random.value, Random.value, Random.value);
        state.AddCallback("BalloonColor", ColorChanged);

        if (entity.IsOwner)
        {
            cam.enabled = true;
            cam.gameObject.SetActive(true);
        }

        if (entity.IsOwner)
        {
            GameObject clientVars = GameObject.Find("ClientVariables");
            Color kleur = clientVars.GetComponent<DontDestroy>().chosenColor;
            if (clientVars)
            {
                state.BalloonColor = kleur;
            }
        }


    }


    public override void SimulateOwner()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("THE KEY OR MOUSEBUTTON WAS PRESSED");
            moveForward = !moveForward;

        }

        if (moveForward)
        {
            transform.position = transform.position + Camera.main.transform.forward * moveSpeed * BoltNetwork.FrameDeltaTime;
        }

    }

    void ColorChanged()
    {
        ballon.GetComponent<Renderer>().material.color = state.BalloonColor;
    }


}
