using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Soldier : MonoBehaviour, IPointerClickHandler
{
    public static int id = 0;
    public GameObject boss;
    public int thId;

    public void OnPointerClick(PointerEventData eventData)
    {
        boss.GetComponent<Boss>().counter += 1;
        boss.GetComponent<Boss>().addinlist(thId);
    }

    // Start is called before the first frame update
    void Start()
    {
        id += 1;
        thId = id;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
