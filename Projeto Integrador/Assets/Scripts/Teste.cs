using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{
    public GameObject boardUI;
    private void Awake()
    {
        PlayerPrefs.DeleteKey("pontuacao");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            boardUI.SetActive(true);
            PlayerPrefs.SetInt("chaves",Player_controller.instance.keyB);
            PlayerPrefs.SetInt("pontuacao", Player_controller.instance.totalScore);
            Invoke("SwitchScene", 3);
            
        }
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene("Cena2");
    }
}
