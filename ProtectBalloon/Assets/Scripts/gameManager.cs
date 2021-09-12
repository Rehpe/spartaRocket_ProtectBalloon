using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject squares;
    public GameObject shield;
   
    public Text timeText;

    public GameObject panel;

    public Animator anim;
    public GameObject balloon;

    float time = 0.00f;

    void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("squaresFall", 0.5f, 0.5f);
        initGame();
    }

    void initGame()
    {
        Time.timeScale = 1.0f;
        time = 0.00f;
    }

    void squaresFall()
    {
        Instantiate(squares);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }
   
    public void gameover()
    {
        anim.SetBool("isDie", true);
        panel.SetActive(true);
        Invoke("boom", 0.5f);
    }

    void boom()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }

    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
}
