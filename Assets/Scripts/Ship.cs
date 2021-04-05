using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    GameObject fire;

    [SerializeField]
    float velocidade = 5f;

    Vector3 bottomLeftWorld, topRightWorld;

    // Start is called before the first frame update
    void Start()
    {
        bottomLeftWorld = Camera.main.ViewportToWorldPoint(Vector2.zero);
        topRightWorld = Camera.main.ViewportToWorldPoint(Vector2.one);

        Debug.Log(bottomLeftWorld);
        Debug.Log(topRightWorld);
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Se o jogador premir o espaço
         * então criar um disparo
         */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, transform);
        }

        float hMov = Input.GetAxis("Horizontal");
        transform.position += hMov * velocidade * Vector3.right * Time.deltaTime;

        Vector3 position = transform.position;

    }
}