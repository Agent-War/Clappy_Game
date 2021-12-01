using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Clappy : MonoBehaviour
{
    public float speed;
    Rigidbody2D clappy;
    bool input;

    public Score scoretxt;
    public GameObject re;
    public GameObject paus;
    public GameObject resume;
    // Start is called before the first frame update
    void Start()
    {
        input = true;
        Time.timeScale = 0;
        clappy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (input)
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetMouseButtonDown(0))
                clappy.velocity = 1.25f * (Vector2.up * speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Column"))
        {
            print("score up");
            scoretxt.scoreup();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            Time.timeScale = 0;
            input = false;
            re.SetActive(true);
            paus.SetActive(false);
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void pse()
    {
        Time.timeScale = 0;
        input = false;
        resume.SetActive(true);
        paus.SetActive(false);
    }

    public void rsu()
    {
        resume.SetActive(false);
        input = true;
        paus.SetActive(true);
        Time.timeScale = 1;
    }
}
