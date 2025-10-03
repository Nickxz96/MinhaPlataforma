using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovel : MonoBehaviour
{
    public Transform pontoA;
    public Transform pontoB;
    public Transform plataforma;
    public float velocidade = 1f;
    void Start()
    {
        transform.position = pontoA.position;
        plataforma = pontoB;
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, plataforma.position, velocidade * Time.deltaTime);
        
        if(Vector3.Distance(transform.position, plataforma.position) < 0.1f)
        {
            if(plataforma == pontoB)
            {
                plataforma = pontoA;
            }
            else
            {
                plataforma = pontoB;
            }
        }

    }
    private void OnCollisonEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            col.transform.SetParent(null);
        }
    }
}
