using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public int score;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("round", 0);
        text.text = "Ваш счёт " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
