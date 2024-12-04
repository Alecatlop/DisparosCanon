using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    GameObject posicion;
    GameObject posicion2;
    int contadorBalas = 0;
    public GameManagerscript game;
    public Renderer cañon;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 fin;
    Vector3 balapos;

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion");
       posicion2 = GameObject.Find("Posicion2");
       balapos = bala.transform.position;
       inicio = posicion.transform.position;
       fin = posicion2.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        float dist = Vector3.Distance(inicio, fin);

        //if (balaInstancia != null)
        //{
            
        //    cañon.material.color = Color.red;
        //}
        //else cañon.material.color = Color.white;

        if(balapos != null)
        {
            cañon.material.color = Color.red;
        }
        else cañon.material.color = Color.white;
    }

    public void OnMouseDown()
    {

        balaInstancia = Instantiate(bala, inicio, Quaternion.identity);


        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerza, fuerza));

        game.IncBalas();

    }

}
