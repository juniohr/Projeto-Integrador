using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject [] menus;
    void Awake()
    {
        PlayerPrefs.DeleteKey("char");
        PlayerPrefs.DeleteKey("iniciar");
        PlayerPrefs.DeleteKey("chaveB");
        PlayerPrefs.DeleteKey("chaveG");
    }

    void Start()
    {
        menus[0].SetActive(false);
        menus[2].SetActive(false);
        menus[3].SetActive(false);
    }

    void Update()
    {
        if (menus[0].activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            menus[1].SetActive(true);
            menus[0].SetActive(false);
            menus[3].SetActive(false);
        }
        else if (menus[2].activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
        {
            menus[1].SetActive(true);
            menus[2].SetActive(false);
            menus[3].SetActive(false);
        }

      
    }
    public void Ferret()
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

    public void StartGame()
    {
        menus[1].SetActive(false);
        menus[0].SetActive(true);
        menus[3].SetActive(true);

    }

    public void Credits()
    {
        menus[1].SetActive(false);
        menus[2].SetActive(true);
        menus[3].SetActive(true);
    }

    public void Back()
    {
        if (menus[0].activeInHierarchy)
        {
            menus[1].SetActive(true);
            menus[0].SetActive(false);
            menus[3].SetActive(false);
        }

        else
        {
            menus[1].SetActive(true);
            menus[2].SetActive(false);
            menus[3].SetActive(false);
        }
    }
}
