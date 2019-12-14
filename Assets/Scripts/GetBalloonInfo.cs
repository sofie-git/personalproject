using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBalloonInfo : MonoBehaviour
{

    public GameObject ballon;

    public GameObject infoCanvas;


    public void changeColor()
    {
        //ballon = this.gameObject.transform.GetChild(0).gameObject;
        Debug.Log("I clicked the balloon");
        Debug.Log("The color is: " + ballon.GetComponent<Renderer>().material.color);
        ballon.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void showPanel()
    {
        infoCanvas.gameObject.SetActive(true);
    }

    public void hidePanel()
    {
        infoCanvas.gameObject.SetActive(false);
    }
}
