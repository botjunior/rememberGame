using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int counter;

    public bool posBool = true;
    public bool go = false;

    public List<int> pos = new List<int>();
    public List<int> posled = new List<int>();

    public Material ErrorMaterial;
    public Material GoogMaterial;
    public Material BaseMaterial;

    public GameObject[] AllCube;

    public RuntimeAnimatorController anim;
    public RuntimeAnimatorController goodanim;
    public RuntimeAnimatorController badanim;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            PlayerPrefs.SetInt("round", counter);
            Debug.Log(PlayerPrefs.GetInt("round"));
            SceneManager.LoadScene(1);
        }
    }

    public bool checkvalue(){ return pos[counter-1] == posled[counter-1] ? true : false; }

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
    private void Start()
    {
        reset();
    }
    public void addinlist(int i)
    {
        posled.Add(i);
    }

    public void reset()
    {
        if (posBool == true)
        {
            pos.Clear();
            int j;
            for (int i = 0; i < counter; i++)
            {
                j = Random.Range(1, 16);
                pos.Add(j);
            }
            posBool = false;
        }
        if (counter == pos.Count)
        {
            controll();
            counter = 0;
        }
    }
}
