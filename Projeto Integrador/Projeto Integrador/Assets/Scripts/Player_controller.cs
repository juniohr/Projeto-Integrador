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
        keyB = PlayerPrefs.GetInt("chaveB");
        keyG = PlayerPrefs.GetInt("chaveG");
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

        if (keyG == 1)
        {
            keys[1].SetActive(true);
        }

        if (keyO == 1)
        {
            keys[2].SetActive(true);
        }

        Score();
    }
    public void Score()
    {
        txt.text = totalScore.ToString();
    }

    public void Gameover()
    {
        if (Lever.lever.fase == "fase1")
        {
            PlayerPrefs.DeleteKey("chaveB");   
        }
        else if (Lever.lever.fase == "fase2")
        {
            PlayerPrefs.DeleteKey("chaveG");
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
}
