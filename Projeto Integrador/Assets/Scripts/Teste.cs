using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teste : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.DeleteKey("pontuacao");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("pontuacao",Player_controller.instance.totalScore);
            SceneManager.LoadScene("Cena2");
        }
    }
}
