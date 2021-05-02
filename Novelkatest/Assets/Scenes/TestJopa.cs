using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJopa : MonoBehaviour
{
    // Start is called before the first frame update
    public int JopaValue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JopaValue = PlayerPrefs.GetInt("round");
    }
}
