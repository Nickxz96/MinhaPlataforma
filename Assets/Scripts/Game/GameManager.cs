using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI placar;
    int pontuacao = 0;
    
    void Start()
    {
        pontuacao = 0;   
    }

    
    void Update()
    {
        
    }


    public void AtualizarTextoPontos()
    {
        placar.text = "Pontos = " + pontuacao;
    }

    public void adicionarPontos(int coleta)
    {
        pontuacao += coleta;
        AtualizarTextoPontos();
    }

}
