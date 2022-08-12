using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objeto : MonoBehaviour
{
    public GameObject Cubo_Cortado;
  


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "faca" )
        {
            

            Instantiate(Cubo_Cortado, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    
    }
}
