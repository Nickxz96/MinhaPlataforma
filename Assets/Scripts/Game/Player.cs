using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int velocidade = 5;

    Rigidbody2D rb;
    Vector2 movimento;
    public int pulo = 36;

    [Header("Check Chão")]
    public Transform checkChao;
    public float raioChao = 0.2f;
    public LayerMask oQueEChao;
    public bool noChao;

    public int pulosMAx = 2;
    int restaPulos;

    public AudioSource somPassos;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        restaPulos = pulosMAx;
    }

    void Update()
    {
        if(movimento.x != 0 && noChao)
        {
            somPassos.Play();
        }
        noChao = Physics2D.OverlapCircle(checkChao.position, raioChao, oQueEChao);
        if (noChao)
        {
            restaPulos = pulosMAx;
        }

        if(movimento.x != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(movimento.x), 1, 1);
        }
    }

    public void OnMover(InputAction.CallbackContext context)
    {
        movimento = context.ReadValue<Vector2>();
    }


    public void OnPular(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed && restaPulos >0)
        {
            rb.AddForce(Vector2.up * pulo);
            restaPulos--;
        }
    }

    void FixedUpdate()
    {
        rb.velocity=new Vector2(movimento.x * velocidade, rb.velocity.y);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(checkChao.position, raioChao);
    }
}
