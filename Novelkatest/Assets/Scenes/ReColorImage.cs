using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ReColorImage : MonoBehaviour, IPointerClickHandler
{
    public Image image;
    public Color color = new Color(100,200,35);
    public void OnPointerClick(PointerEventData eventData)
    {
        image.color = color;
        Debug.Log(color);
    }

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        color = new Color(100,31,200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
