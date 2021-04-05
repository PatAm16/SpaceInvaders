using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); //Destruir-me
        Destroy(collision.gameObject); //Destruir o objeto que colidiu comigo
    }
}