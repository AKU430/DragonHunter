using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnclickStage1_1()
    {
        SceneManager.LoadScene("Scenes/1-1");
    }
    
    public void OnclickStage1_2()
    {
        
    }
    
    public void OnclickStage1_3()
    {
        
    }
    
    public void OnclickBack()
    {
        SceneManager.LoadScene("Scenes/ChapterSelector");
    }
}

