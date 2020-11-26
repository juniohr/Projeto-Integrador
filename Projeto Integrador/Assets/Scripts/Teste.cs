using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{
    public GameObject boardUI;
    public GameObject[] keys;
    public GameObject endGame;
    public string cenas;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boardUI.SetActive(true);

            if (Player_controller.instance.keyB == 1)
            {
                keys[0].SetActive(true);
            }
            if (Player_controller.instance.keyG == 1)
            {
                keys[1].SetActive(true);
            }
            if (Player_controller.instance.keyO == 1)
            {
                keys[2].SetActive(true);
            }
            if (Player_controller.instance.keyO == 1 && Player_controller.instance.keyG == 1 && Player_controller.instance.keyB == 1)
            {
                keys[3].SetActive(true);
            }

            PlayerPrefs.SetInt("chaveB",Player_controller.instance.keyB);
            PlayerPrefs.SetInt("chaveG", Player_controller.instance.keyG);

            if (cenas == "Cena2" || cenas == "Cena3")
            {
                Invoke("SwitchScene", 3);
            }
            Invoke("Endgame", 5);
            
        }
    }

    public void Endgame()
    {
        endGame.SetActive(true);
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(cenas);
    }
}
