using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoSceneWithId : MonoBehaviour
{
    // Start is called before the first frame update
    public string nextsceneName;
    public Button buttonNextScene;
    void Start()
    {
        buttonNextScene.onClick.AddListener(nextscene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextscene()
    {
        SceneManager.LoadScene(nextsceneName);
    }

}
