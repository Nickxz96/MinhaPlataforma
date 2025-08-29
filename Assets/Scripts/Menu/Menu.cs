using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
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
}
