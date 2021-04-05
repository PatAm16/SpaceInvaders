using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField]
    float force = 100f;


    // Start is called before the first frame update
    void Start()
    {
        // Caso quisessemos usar antes a velocidade em vez da força: GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidade;

        GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

}