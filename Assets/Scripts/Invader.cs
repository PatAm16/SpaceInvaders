using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{

    [SerializeField]
    GameObject fire = null;


    float cadencia;

    float tempoQuePassou = 0f;

    float disparosNecessarios = 10;

    float disparosAtingidos = 0f;

    void Update()
    {
        if (tag == "Destrutivel")
        {
            cadencia = Random.Range(2f, 3f);
            tempoQuePassou += Time.deltaTime;
            if (tempoQuePassou >= cadencia)
            {
                Instantiate(fire, transform.position, transform.rotation);
                tempoQuePassou = 0f;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (tag == "Destrutivel")
        {
                if (collision.gameObject.tag == "DisparoDaNave")
                {
                    Destroy(gameObject); //Destruir-me
                    Destroy(collision.gameObject); //Destruir o objeto que colidir comigo
                }
        }

        if (tag == "Indestrutivel")
        {
            if (collision.gameObject.tag == "DisparoDaNave")
            {
                disparosAtingidos += 1f;
                Destroy(collision.gameObject);

                if(disparosAtingidos >= disparosNecessarios)
                {
                    Destroy(gameObject);
                }
            }
        }

    }
}