using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    GameObject posicioninicio;
    int contadorBalas = 0;
    public GameManagerscript game;
    public Renderer cañon;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 balapos;
    GameObject posicionfin;
    float limite = 2f;
    float dist;

    // Start is called before the first frame update
    void Start()
    {
       posicioninicio = GameObject.Find("Posicion inicio");
       inicio = posicioninicio.transform.position;
       posicionfin = GameObject.Find("Posicion fin");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (balaInstancia != null)
        {
            balapos = balaInstancia.transform.position;
            dist = Vector3.Distance(inicio, balapos);

            if (dist < limite)
            {
                cañon.material.color = Color.red;
            }
            else cañon.material.color = Color.white;
        }
        
    }

    public void OnMouseDown()
    {

        balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        Vector3 fin = posicionfin.transform.position;

        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio) * fuerza);

        game.IncBalas();

    }

}
