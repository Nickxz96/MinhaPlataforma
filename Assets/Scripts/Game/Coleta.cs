using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleta : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("fruta"))
        {
            gameManager.adicionarPontos(1);
            Destroy(collision.gameObject, 0.5f);
        }
    }

}
