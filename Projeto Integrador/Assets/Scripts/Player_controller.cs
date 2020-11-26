using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_controller : MonoBehaviour
{
    public int i;
    public static Player_controller instance;
    public GameObject gameOver, startGame;
    public GameObject[] players;
    public GameObject[] keys;
    public string inicio;
    public int keyB, keyO, keyG;

    Vector2 velocity;
    public float smoothTimeX, smoothTimeY;
    public bool bounds;
    public GameObject player;
    public Vector3 minCameraPos, maxCameraPos;

    private void Awake()
    {
       
    }
    void Start()
    {
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
        instance = this;
        keyB = PlayerPrefs.GetInt("chaveB");
        keyG = PlayerPrefs.GetInt("chaveG");
        player = GameObject.FindGameObjectWithTag("Player");
        

    }
    private void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(Camera.main.transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(Camera.main.transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);
        Camera.main.transform.position = new Vector3(posX, posY, Camera.main.transform.position.z);

        if (bounds)
        {
            Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, minCameraPos.x, maxCameraPos.x),
            Mathf.Clamp(Camera.main.transform.position.y, minCameraPos.y, maxCameraPos.y),
            Mathf.Clamp(Camera.main.transform.position.z, minCameraPos.z, maxCameraPos.z));
        }



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
