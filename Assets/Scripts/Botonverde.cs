using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    GameObject posicion;
    int contadorBalas = 0;
    public GameManagerscript game;
    public Renderer cañon;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 balapos;
    float limite = 2f;
    float dist;

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion");
       inicio = posicion.transform.position;
       
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
        balapos = balaInstancia.transform.position;
        dist = Vector3.Distance(inicio, balapos);

        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerza, fuerza));

        game.IncBalas();

    }

    
}
