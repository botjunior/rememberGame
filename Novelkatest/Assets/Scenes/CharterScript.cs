using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharterScript : MonoBehaviour, IPointerClickHandler
{
    public string _story;
    public string _louality;
    public string _name;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("story: " + _name + " louality: "+ _louality + " name: " + _name);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
