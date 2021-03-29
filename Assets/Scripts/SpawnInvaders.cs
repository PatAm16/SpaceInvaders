using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;


    [SerializeField]
    float xMin = -3f;

    void Awake()
    {

        /* "Pega" num invader e coloca "nesta" posição
         * Repete
         */


        float x = xMin;
        for (int i = 1; 1 <= nInvasores; i++)
        {

            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(xMin, -0.5f, 0f);
            xMin *= 1f;

        }


    }
}