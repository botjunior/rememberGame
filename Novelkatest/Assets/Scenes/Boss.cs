using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public int counter;
    public int num;
    public float seconds = 0;

    public Text scroeText;

    public bool clicable = false;

    public List<int> pos = new List<int>();
    public List<int> posled = new List<int>();

    public Material ErrorMaterial;
    public Material GoogMaterial;
    public Material BaseMaterial;

    public GameObject[] AllCube;
    

    public RuntimeAnimatorController anim;
    public RuntimeAnimatorController goodanim;
    public RuntimeAnimatorController badanim;

    public bool answer() { return pos[posled.Count - 1] == posled[posled.Count - 1] ? true : false; }
    void Start()
    {
       // AllCube = GameObject.FindGameObjectsWithTag("Cube");
        gamelogic();
        showpos();
        scroeText.text = "Score: " + 0;
        Application.targetFrameRate = 60;
    }

    public void addclickobject(GameObject tmp)
    {
        posled.Add(tmp.GetComponent<Soldier>().thId);
        animatedobject(tmp);
        newround();

    }
    void newround()
    {
        if (counter == posled.Count) {
            scroeText.text = "Score: " + counter;
            counter++;
            gamelogic();
            posled.Clear();
            showpos();
            clicable = false;
        }
        Debug.Log("Check");
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
            nextScene();
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

            StartCoroutine(TouchTimer());

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
    public IEnumerator TouchTimer(){
        for (int i = 0; i < pos.Count; i++)
        {
            yield return new WaitForSeconds(2);
            GameObject gtmp = findobjectwithid(pos[i]);
            gtmp.GetComponent<Animator>().runtimeAnimatorController = null;
            gtmp.GetComponent<Animator>().runtimeAnimatorController = goodanim;
        }
        clicable = true;
    }
    public IEnumerator enable()
    {
        yield return new WaitForSeconds(1);
        clicable = true;
        
    }
    void enableobj()
    {
        for (int i = 0; i < AllCube.Length; i++)
        {
            AllCube[i].GetComponent<Soldier>().enabled = !AllCube[i].GetComponent<Soldier>().enabled;
        }
    }
    void nextScene()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetInt("round", counter-1);
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
