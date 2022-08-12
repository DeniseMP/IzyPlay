using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    public GameObject faca;
    public bool controle2;


    public void Carregar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}
