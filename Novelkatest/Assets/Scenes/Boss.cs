using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int counter = 0;
    public bool posBool = true;
    public bool go = false;
    public List<int> pos = new List<int>();
    public List<int> posled = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (posBool == true)
        {
            pos.Clear();
            int j;
            for (int i = 0; i < counter;i++)
            {
                j = Random.Range(1, 16);
                pos.Add(j);
            }
            posBool = false;
        }
        if (counter  == pos.Count)
        {
            controll();
            counter = 0;
        }
    }
    public void controll()
    {
        bool identity = true;
        for (int i = 0; i < pos.Count && i < posled.Count;i++)
        {
            if (pos[i] != posled[i])
            {
                identity = false;
                break;
            }
        }
        posled.Clear();
        Debug.Log("Its resultat: " + identity);
    }
    public void addinlist(int i)
    {
        posled.Add(i);
    }
}
