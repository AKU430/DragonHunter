using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    
    public GameObject Rweap;
    public GameObject Uweap;
    public GameObject Lweap;
    public GameObject Dweap;


    private Rigidbody2D rigid;
    private SpriteRenderer spriter;
    private Animator anim;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.y = Input.GetAxisRaw("Vertical");
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rweap.gameObject.SetActive(true);
        }
        else
        {
            Rweap.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Uweap.gameObject.SetActive(true);
        }
        else
        {
            Uweap.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Lweap.gameObject.SetActive(true);
        }
        else
        {
            Lweap.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Dweap.gameObject.SetActive(true);
        }
        else
        {
            Dweap.gameObject.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }

    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);
        
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
    }
}
