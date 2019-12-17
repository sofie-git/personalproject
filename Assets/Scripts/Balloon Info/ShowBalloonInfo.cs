using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class ShowBalloonInfo : MonoBehaviour
{

    private bool infoIsActive = false;

    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;
    public GameObject infoManager;

    void Start()
    {
        infoManager = GameObject.Find("/InfoManager");

    }


    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
        }

        if (gvrTimer > totalTime)
        {
            GVRClick.Invoke();
            gvrTimer = 0;
        }
    }

    public void GazeOn()
    {
        Debug.Log("GAZE ON");
        gvrStatus = true;
    }

    public void GazeOff()
    {
        Debug.Log("GAZE OFF");
        gvrStatus = false;
        gvrTimer = 0;
    }

    public void CallInfoManager()
    {
        infoManager.GetComponent<InfoManager>().ShowInfoCanvas();
    }


}
