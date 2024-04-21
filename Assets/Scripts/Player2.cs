using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine.UIElements;

public class Player2 : MonoBehaviour
{
    public Canvas canvas;
    public TextMeshProUGUI text;
    public float speed;
    public int hp;
    public GameObject Hp;

    public GameObject Rweap;
    public GameObject Uweap;
    public GameObject Lweap;
    public GameObject Dweap;

    private Rigidbody2D rigid;
    private SpriteRenderer spriter;
    private Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        text.text = $"HP: {hp}";
        canvas.gameObject.SetActive(false);
        {
            hp = 100;
            text.text = $"HP: {hp}";
            foreach (var o in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                Destroy(o.gameObject);
            }

            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

//-----------------------------------------------------------------------------------------
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
        if (hp <= 0)
        {
            Time.timeScale = 0;
            canvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            hp -= 1;
            Destroy(other.gameObject);

            text.text = $"HP: {hp}";
        }
    }

}