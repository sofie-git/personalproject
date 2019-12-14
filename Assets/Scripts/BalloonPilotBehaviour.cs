using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPilotBehaviour : Bolt.EntityBehaviour<IBalloonState>
{

    public float moveSpeed = 3f;
    private bool moveForward = false;

    public Camera cam = null;
    public override void Attached()
    {
        //cam = Camera.main;
        state.SetTransforms(state.BalloonTransform, transform);
        //state.BalloonColor = new Color(Random.value, Random.value, Random.value);
        //state.AddCallback("BalloonColor", ColorChanged);

        if (entity.IsOwner)
        {
            Debug.Log(cam);
            cam.enabled = true;
            cam.gameObject.SetActive(true);
            // Camera mainCam = transform.Find("mandje").gameObject.Find("Main Camera").camera;
            // Debug.Log("mainCam");
            // Debug.Log(mainCam);
            // if (mainCam)
            // {
            //     mainCam.enabled = true;
            // }
            // else
            // {
            //     Debug.Log("no maincam found");
            // }
            // mainCam.enabled = true;
            //Debug.Log(mainCam);
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


}
