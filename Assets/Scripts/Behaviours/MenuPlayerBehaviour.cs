using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayerBehaviour : MonoBehaviour
{
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;
    float passedTime = 0;

    void Start()
    {

    }


    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += BoltNetwork.FrameDeltaTime;
            passedTime = gvrTimer / totalTime;
        }
    }

    public void gazeOn()
    {
        gvrStatus = true;
    }

    public void gazeOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
    }
}
