using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Awake()
    {
        PlayerPrefs.DeleteKey("char");
        PlayerPrefs.DeleteKey("iniciar");
    }

    public void Frog()
    {
        Player_controller.instance.i = 0;
        PlayerPrefs.SetInt("char", Player_controller.instance.i);
        Player_controller.instance.inicio = "inicio";
        PlayerPrefs.SetString("iniciar", Player_controller.instance.inicio);
        SceneManager.LoadScene("Cena");
    }

    public void Guy()
    {
        Player_controller.instance.i = 1;
        PlayerPrefs.SetInt("char", Player_controller.instance.i);
        Player_controller.instance.inicio = "inicio";
        PlayerPrefs.SetString("iniciar", Player_controller.instance.inicio);
        SceneManager.LoadScene("Cena");
    }
}
