using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{
    public Image witteCirkel;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            witteCirkel.fillAmount = gvrTimer / totalTime;
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
        witteCirkel.fillAmount = 0;
    }
}
