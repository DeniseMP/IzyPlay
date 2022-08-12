using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{

    public GameObject faca;
    private Vector3 velocidade = Vector3.zero;
    public Vector3 Distancia;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.SmoothDamp(transform.position, faca.transform.position + Distancia, ref velocidade, 0.7f);
        
    }
}
