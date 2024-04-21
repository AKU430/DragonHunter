using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnclickNewGame()
    {
        SceneManager.LoadScene("Scenes/ChapterSelector");
    }

    public void OnclickTutorial()
    {
        SceneManager.LoadScene("Scenes/Tutorial");
    }
    
    public void OnclickLoad()
    {
        
    }
    
    public void OnclickQuit()
    {
        Application.Quit();
    }
}
