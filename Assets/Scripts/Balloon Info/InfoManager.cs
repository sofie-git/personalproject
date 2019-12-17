using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class InfoManager : MonoBehaviour
{
    public GameObject infoCanvas;
    public GameObject colorBlock;
    private bool infoIsActive = false;
    public float totalTime = 3;
    public float infoTimer;

    void Start()
    {
        infoCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (infoIsActive)
        {
            // wacht twee seconden en dan weer op false
            infoTimer += Time.deltaTime;
        }

        if (infoTimer > totalTime)
        {
            infoIsActive = false;
            infoCanvas.gameObject.SetActive(false);
            infoTimer = 0;
        }
    }

    public void ShowInfoCanvas()
    {
        Debug.Log("Ik zit in de SHOWINFOCANVAS");
        // if (infoIsActive == false)
        // {
        infoIsActive = true;
        infoCanvas.gameObject.SetActive(true);
        //}

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selectedPilot = hit.transform;
            var pilotBallon = selectedPilot.transform.Find("ballon").gameObject;
            colorBlock.GetComponent<Image>().color = pilotBallon.GetComponent<Renderer>().material.color;
        }
    }

    public void hideInfoCanvas()
    {
        infoCanvas.gameObject.SetActive(false);
    }
}
