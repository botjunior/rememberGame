using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CanvasDialogeScript : MonoBehaviour, IPointerClickHandler
{
    public string[] text;
    public int counter = 0;
    public GameObject TextFieldObject; // Max 132
    public string tmp;
    // Start is called before the first frame update
    void Start()
    {
        if (text.Length > 0)
        {
            TextFieldObject.GetComponent<Text>().text = text[0];
        }
        Debug.Log(tmp.Length);
    }
    void textcontroller()
    {
        if (counter == text.Length)
        {
            counter = 0;
        }
        if (TextFieldObject != null)
        {
            TextFieldObject.GetComponent<Text>().text = text[counter];
        }
        if (counter < text.Length)
        {
            counter++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        textcontroller();
    }
}

