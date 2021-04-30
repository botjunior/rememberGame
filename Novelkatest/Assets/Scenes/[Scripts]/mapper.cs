using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapper : MonoBehaviour
{
    public Material ErrorMaterial;
    public Material GoodMaterial;
    public Material AlertMaterial;
    public int waitSeconds = 0;
    public int howLong = 0;
    public bool iCanGo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void print()
    {
        Debug.Log("Hey ho");
    }
    // Update is called once per frame
    void Update()
    {
        if (waitSeconds > 0 && iCanGo == true)
        {
            waitSeconds -= howLong;
            
            StartCoroutine(WaitCoroutine());
        }
    }
    IEnumerator WaitCoroutine()
    {
        iCanGo = false;
        yield return new WaitForSeconds(howLong);
        print();
        iCanGo = true;
    }
}
