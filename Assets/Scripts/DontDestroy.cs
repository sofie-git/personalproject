using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    public Color chosenColor;
    public GameObject colorPreview;

    public GameObject KleurOranje;
    public GameObject KleurRoze;
    public GameObject KleurBlauw;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        chosenColor = new Color(Random.value, Random.value, Random.value);
        colorPreview.GetComponent<Image>().color = chosenColor;
    }

    public void ChooseColor(string colorString)
    {
        if (colorString == "oranje")
        {
            chosenColor = KleurOranje.GetComponent<Image>().color;
        }
        else if (colorString == "roze")
        {
            chosenColor = KleurRoze.GetComponent<Image>().color;
        }
        else if (colorString == "blauw")
        {
            chosenColor = KleurBlauw.GetComponent<Image>().color;
        }
        Debug.Log(colorString);
        colorPreview.GetComponent<Image>().color = chosenColor;
    }

    public void randomColor()
    {
        chosenColor = new Color(Random.value, Random.value, Random.value);
        colorPreview.GetComponent<Image>().color = chosenColor;
    }
}
