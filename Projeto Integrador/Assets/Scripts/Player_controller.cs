using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_controller : MonoBehaviour
{
    public Text txt;
    public int totalScore , i;
    public static Player_controller instance;
    public GameObject gameOver, startGame;
    public GameObject[] players;
    public GameObject[] keys;
    public string inicio;
    public int keyB, keyO, keyG;
    void Start()
    {
        instance = this;
        keyB = PlayerPrefs.GetInt("chaves");
        totalScore = PlayerPrefs.GetInt("pontuacao");
        i = PlayerPrefs.GetInt("char");
        inicio = PlayerPrefs.GetString("iniciar");

        if (inicio == "inicio")
        {
            if (i == 0)
            {
                Instantiate(players[0], startGame.transform.position, Quaternion.identity);
            }
            else if (i == 1)
            {
                Instantiate(players[1], startGame.transform.position, Quaternion.identity);
            }
        }

    }
    private void FixedUpdate()
    {
        if (keyB == 1)
        {
            keys[0].SetActive(true);
        }
        Score();
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
