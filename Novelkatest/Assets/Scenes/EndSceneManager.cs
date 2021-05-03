using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Button exit;
    public Button mainmenu;
    public string nextscene;
    void Start()
    {
        exit.onClick.AddListener(exitf);
        mainmenu.onClick.AddListener(nextscenef);
    }
    void exitf()
    {
        Application.Quit();
    }
    void nextscenef()
    {
        SceneManager.LoadScene(nextscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
