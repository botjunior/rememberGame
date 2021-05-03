using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int counter;
    public int num;


    public bool posBool = true;
    public bool go = false;

    public List<int> pos = new List<int>();
    public List<int> posled = new List<int>();

    public Material ErrorMaterial;
    public Material GoogMaterial;
    public Material BaseMaterial;

    public GameObject[] AllCube;
    public GameObject Kohn;

    public RuntimeAnimatorController anim;
    public RuntimeAnimatorController goodanim;
    public RuntimeAnimatorController badanim;

    public bool answer() { return pos[posled.Count - 1] == posled[posled.Count - 1] ? true : false; }
    void Start()
    {
       // AllCube = GameObject.FindGameObjectsWithTag("Cube");
        gamelogic();
        showpos();
    }

    public void addclickobject(GameObject tmp)
    {
        posled.Add(tmp.GetComponent<Soldier>().thId);
        animatedobject(tmp);
    }

    public void animatedobject(GameObject tmp)
    {
        if (answer())
        {
            tmp.GetComponent<Animator>().runtimeAnimatorController = null;
            tmp.GetComponent<Animator>().runtimeAnimatorController = goodanim;
        }
        else
        {
            tmp.GetComponent<Animator>().runtimeAnimatorController = null;
            tmp.GetComponent<Animator>().runtimeAnimatorController = badanim;
        }
    }

    public void gamelogic()
    {
        pos.Clear();
        for (int i = 0; i < counter; i++)
        {
            pos.Add(Random.Range(1,AllCube.Length));
        }
        Debug.Log("Range cube = " + AllCube.Length);
    }
    public void showpos()
    {
        for (int i = 0; i < pos.Count;i++)
        {
            StartCoroutine(TouchTimer(pos[i], 3, i));
            Debug.Log(i);
        }
    }
    public GameObject findobjectwithid(int tmpid)
    { 
    Debug.Log("tnpid " + tmpid);
        for (int i = 0; i < AllCube.Length; i++)
        { 
            if (AllCube[i].GetComponent<Soldier>().thId == tmpid)
            {
                return AllCube[i];
            }
        }
        return null;
    }
    public IEnumerator TouchTimer(int tmpid,int seconds, int i){
        yield return new WaitForSeconds(seconds + i);
        GameObject gtmp = findobjectwithid(tmpid);
        gtmp.GetComponent<Animator>().runtimeAnimatorController = null;
        gtmp.GetComponent<Animator>().runtimeAnimatorController = goodanim;
        yield return new WaitForSeconds( 2 * seconds + i);
    }
    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            PlayerPrefs.SetInt("round", counter);
            Debug.Log(PlayerPrefs.GetInt("round"));
            SceneManager.LoadScene(1);
        }
    }

    public void addclickid(int id)
    {
        posled.Add(id);
    }

   

    public bool answer(){ return pos[num - 1] == posled[num - 1] ? true : false; }

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
    }*/
}
