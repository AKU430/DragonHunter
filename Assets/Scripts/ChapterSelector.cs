using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChpterSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnclickChapter1()
    {
        SceneManager.LoadScene("Scenes/StageSelectorC1");
    }
    
    public void OnclickChapter2()
    {
        
    }
    
    public void OnclickChapter3()
    {
        
    }
    
    public void OnclickBack()
    {
        SceneManager.LoadScene("Scenes/Start");
    }
}
