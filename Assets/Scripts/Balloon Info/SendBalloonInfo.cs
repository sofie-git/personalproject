using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendBalloonInfo : MonoBehaviour
{
    public GameObject infoManager;

    void Start()
    {
        infoManager = GameObject.Find("/InfoManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sendInfo()
    {
        //infoManager.GetComponent<ShowBalloonInfo>().ShowInfoCanvas();
    }
}
