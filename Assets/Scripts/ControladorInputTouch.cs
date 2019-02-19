using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputTouch : MonoBehaviour
{
    private void Update()
    {
        //exibir quantidade de toques
        //int quantidadeToques = Input.touchCount;
        //print(quantidadeToques);
        //Debug.Log(quantidadeToques);

        //exibir aceleração de dispositivo
        //var acceleration = Input.acceleration;
        //print(acceleration);

        //exibir posição do toque usando o ''for''
        //var position = Input.mousePosition;
        //print(position);

        //if (quantidadeToques > 0)
        //{
        //    for (int indexToque = 0; indexToque < quantidadeToques; indexToque++)
        //    {
        //        var touch = Input.GetTouch(indexToque);
        //        var positionToque = touch.position;
        //        print(string.Format("Touch: {0} - x: {1}, y:{2}", indexToque, positionToque.x, positionToque.y));
        //        //print(indexToque);
        //        //print(positionPrimeiroToque);
        //    }
        //}

        //exibir a posição de todos os toques usando o ''foreach''
        Touch[] touches = Input.touches;

        foreach (Touch touch in touches)
        {
            var positionToque = touch.position;
            print(string.Format("Touch: {0} - TouchPhase:{3} - x: {1}, y:{2}", touch.fingerId, positionToque.x, positionToque.y, touch.phase));
        }
    }
}