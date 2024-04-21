using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public GameObject weap;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position.Set(6, 0, -25);
            transform.rotation.Set(0,0, -45,875);
            weap.gameObject.SetActive(true);
        }
        else
        {
            weap.gameObject.SetActive(false);
        }
    }
}
