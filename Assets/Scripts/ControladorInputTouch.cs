using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputTouch : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        int quantidadeToques = Input.touchCount;
        print(quantidadeToques);
        //Debug.Log(quantidadeToques);
    }
}