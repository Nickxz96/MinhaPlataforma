using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject painel;
    void Start()
    {
        Time.timeScale = 1f;
    }

    public void jogar()
    {
        SceneManager.LoadScene("Game");
    }

    void Update()
    {
        
    }

    public void creditos()
    {
        painel.SetActive(true);
    }


    public void voltar()
    {
        painel.SetActive(false);
    }
}
