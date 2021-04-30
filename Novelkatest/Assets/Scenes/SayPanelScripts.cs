using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SayPanelScripts : MonoBehaviour
{

    public GameObject backGroundImage;
    public GameObject dialogImage;
    public GameObject textField;
    public GameObject leftImage;//132 - max_size
    [System.Serializable]
    public struct CustomText
    {
        public string[] textPole;
        public int i;
    }

    public CustomText customText = new CustomText();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
