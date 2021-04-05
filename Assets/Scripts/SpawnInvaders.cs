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
    GameObject[] invasores;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


    void Awake()
    {
        /*
         * "Pega" neste objecto, duplica e coloca-o "naquele" sítio
         */

        float y = yMin;
        for (int line = 0; line < invasores.Length; line++)
        { 

            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject newInvader = Instantiate(invasores[line], transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
                y += yInc;
        }
    }


    /*
     * x= xMin
     * for (int i = 1; i <= nInvasores; i++)
     * {
     *      GameObject newInvader = Instantiate(invasorA, transform);
     *      newinvader.transform.position = new Vector3(x,y,0f);
     *      x += xInc;
     *      
     * y += yInc;
     * 
     * 
     * x= xMin
     * for (int i = 1; i <= nInvasores; i++)
     * {
     *      GameObject newInvader = Instantiate(invasorA, transform);
     *      newinvader.transform.position = new Vector3(x,y,0f);
     *      x += xInc;
     *      
     * y += yInc;
     * 
     * 
     * x= xMin
     * for (int i = 1; i <= nInvasores; i++)
     * {
     *      GameObject newInvader = Instantiate(invasorB, transform);
     *      newinvader.transform.position = new Vector3(x,y,0f);
     *      x += xInc;
     *      
     * y += yInc;
     * 
     * 
     * x= xMin
     * for (int i = 1; i <= nInvasores; i++)
     * {
     *      GameObject newInvader = Instantiate(invasorB, transform);
     *      newinvader.transform.position = new Vector3(x,y,0f);
     *      x += xInc;
     *      
     * y += yInc;
     * 
     * 
     * x= xMin
     * for (int i = 1; i <= nInvasores; i++)
     * {
     *      GameObject newInvader = Instantiate(invasorC, transform);
     *      newinvader.transform.position = new Vector3(x,y,0f);
     *      x += xInc;
     *      
     * y += yInc;
     */


}