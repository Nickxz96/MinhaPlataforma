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
    bool ehchao = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }

    public void OnMover(InputAction.CallbackContext context)
    {
        movimento = context.ReadValue<Vector2>();
    }


    public void OnPular(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed && ehchao)
        {
            rb.AddForce(Vector2.up * pulo);
            ehchao = false;
        }
    }

    void FixedUpdate()
    {
        rb.velocity=new Vector2(movimento.x * velocidade, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("chao"))
        {
            ehchao = true;
        }
    }
}
