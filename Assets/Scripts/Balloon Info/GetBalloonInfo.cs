using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GetBalloonInfo : MonoBehaviour
{

    public GameObject ballon;
    public GameObject infoCanvas;
    private bool infoActive = false;
    public GameObject colorBlock;

    void Start(){
        infoCanvas = GameObject.Find("/InfoCanvas");  /////// ERROR
        Debug.Log("DIT IS INFOCANVAS:");
        Debug.Log(infoCanvas);
        infoCanvas.gameObject.SetActive(false);
    }

    public void showPanel()
    {
        Debug.Log("DIT IS INFOCANVAS IN SHOWPANEL:");
        Debug.Log(infoCanvas);
        // if(InfoCanvas){
        //     Debug.Log("Infocanvas bestaat!!");
        // }
        if (infoActive == false){
            infoActive = true;
            infoCanvas.gameObject.SetActive(true);
            colorBlock = infoCanvas.transform.Find("Color").gameObject;
        } else {
            infoActive = false;
            infoCanvas.gameObject.SetActive(false);
        } 

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)) {
            var selectedPilot = hit.transform;
            var pilotBallon = selectedPilot.transform.Find("ballon").gameObject;
            colorBlock.GetComponent<Image>().color = pilotBallon.GetComponent<Renderer>().material.color;
        }
    }
}
