using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimetarCubo : MonoBehaviour
{
    private float xInicial = 0, yInicial = 0, xFinal = 0, yFinal = 0, xDir = 0, yDir = 0;

    // Update is called once per frame
    private void Update()
    {
        var velocidade = 5f;
        var acceleration = Input.acceleration;
        transform.Translate(acceleration.x * velocidade * Time.deltaTime, 0, -acceleration.z * velocidade * Time.deltaTime);

        int quantidadeToques = Input.touchCount;

        if (quantidadeToques > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                xInicial = touch.position.x;
                yInicial = touch.position.y;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                xFinal = touch.position.x;
                yFinal = touch.position.y;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                xDir = xFinal - xInicial;
                yDir = yFinal - yInicial;

                xInicial = 0;
                xFinal = 0;
                yInicial = 0;
                yFinal = 0;
            }
        }
        if (xDir > yDir)
        {
            if (xDir > 0)
            {
                Debug.Log("Direita");
            }
            else if (xDir < 0)
            {
                Debug.Log("Baixo");
            }
        }
        else
        {
            if (yDir > 0)
            {
                Debug.Log("Cima");
            }
            else if (yDir < 0)
            {
                Debug.Log("Esquerda");
            }
        }

        xDir = 0;
        yDir = 0;
    }
}