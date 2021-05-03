using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Soldier : MonoBehaviour, IPointerClickHandler
{
    public GameObject boss;
    public int thId;
    public Material c1;
    public RuntimeAnimatorController anim;
    public bool trucolor = false;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (boss.GetComponent<Boss>().clicable)
        {
            boss.GetComponent<Boss>().addclickobject(this.gameObject);
        }
        
    }
    



    /*public void OnPointerClick(PointerEventData eventData)
    {
        boss.GetComponent<Boss>().reset();
        boss.GetComponent<Boss>().counter += 1;
        boss.GetComponent<Boss>().addinlist(thId);
        trucolor = boss.GetComponent<Boss>().checkvalue();
        Debug.Log(boss.GetComponent<Boss>().counter + " "+boss.GetComponent<Boss>().checkvalue());
        switchcolor();
        
    }

    public void sendDataController()
    {
        boss.GetComponent<Boss>().addclickid(thId);
        boss.GetComponent<Boss>().addclickobject(gameObject);

    }

    void switchcolor()
    {
        gameObject.GetComponent<Animator>().runtimeAnimatorController = null;
        if (trucolor == true)
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = boss.GetComponent<Boss>().goodanim;
        }
        else
        {
            gameObject.GetComponent<Animator>().runtimeAnimatorController = boss.GetComponent<Boss>().badanim;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        id += 1;
        thId = id;
        c1 = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

}
