using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_controller : MonoBehaviour
{
    public Text txt;
    public int totalScore = 0;
    public static Player_controller instance;
    public GameObject gameOver;
    void Start()
    {
        instance = this;
    }

    public void Score()
    {
        txt.text = totalScore.ToString();
    }

    public void Gameover()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
