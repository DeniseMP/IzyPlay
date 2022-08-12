using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtirarFaca : MonoBehaviour
{

    public Rigidbody rb;
    public Rigidbody obj0;
    public Rigidbody obj1;
    public float forca = 20f;
    public float torque = 20f;

    private Vector2 Pula;
    private Vector2 Cai;

    public Text PontuacaoText;
    private int PontuacaoNum;
    public GameObject MenuGameOver;

    public bool controle = false;

    public AudioSource somPulo;


    // Start is called before the first frame update
    void Start()
    {
        PontuacaoNum = 0;
        PontuacaoText.text = "Pontuação: " + PontuacaoNum;
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Cubo")
        {
            PontuacaoNum = PontuacaoNum + 1;
            PontuacaoText.text = "Pontuação: " + PontuacaoNum;

  
        }
        if (col.tag == "Solo")
        {
            AtivaMenuGameOver();
            controle = true;

        }

        if(col.tag == "obj0")
        {
            rb.isKinematic = true;
            Debug.Log("Colidiu0");
            rb.GetComponent<Collider>().enabled = false;
            obj0.GetComponent<Collider>().enabled = false;
           
            AtivaMenuGameOver();
            controle = true;
            PontuacaoNum = PontuacaoNum * 2;
            PontuacaoText.text = "Pontuação: " + PontuacaoNum;

        }
        if (col.tag == "obj1")
        {
            rb.isKinematic = true;
            Debug.Log("Colidiu1");
            rb.GetComponent<Collider>().enabled = false;
            obj1.GetComponent<Collider>().enabled = false;
           
            AtivaMenuGameOver();
            controle = true;
            PontuacaoNum = PontuacaoNum * 4;
            PontuacaoText.text = "Pontuação: " + PontuacaoNum;

        }
        if (col.tag == "obj2")
        {
            Debug.Log("Colidiu2");
            rb.GetComponent<Collider>().enabled = false;
            rb.isKinematic = true;
           AtivaMenuGameOver();
           controle = true;

        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && controle == false)
        {
            Pula = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0) && controle == false)
        {

            Cai = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            ComecaPulo();
        }

        if(Input.touchCount > 0 && controle == false)
        {
            Touch t = Input.GetTouch(0);

            if(t.phase == TouchPhase.Moved)
            {
                rb.AddForce(t.deltaPosition/10000 * forca, ForceMode.Impulse);
                rb.AddTorque(-torque, 0f, 0f, ForceMode.Impulse);
                somPulo.Play();

            }

        }
    
        
    }

    void ComecaPulo()
    {
        Vector2 Movimento = Cai - Pula;
        rb.AddForce(Movimento * forca, ForceMode.Impulse);
        rb.AddTorque(-torque, 0f, 0f, ForceMode.Impulse);
        somPulo.Play();
    }

    public void AtivaMenuGameOver()
    {

        MenuGameOver.SetActive(true);


    }
}


