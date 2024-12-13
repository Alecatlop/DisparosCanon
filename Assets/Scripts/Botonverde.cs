using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    GameObject posicion;
    GameObject cruceta;
    int contadorBalas = 0;
    public GameManagerscript game;
    public Renderer cañon;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 fin;
    Vector3 balapos;
    float limite = 2f;
    float dist;
    bool cargar = false;

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion");
       cruceta = GameObject.Find("cruceta");
    }

    // Update is called once per frame
    void Update()
    {
        inicio = posicion.transform.position;
        fin = cruceta.transform.position;

        //if (balaInstancia != null)
        //{
        //    balapos = balaInstancia.transform.position;
        //    dist = Vector3.Distance(inicio, balapos);

        //    if (dist < limite)
        //    {
        //        cañon.material.color = Color.red;
        //    }
        //    else cañon.material.color = Color.white;
        //}

    }

    public void OnMouseDown()
    {
        cargar = true;
        cañon.material.color = Color.red;
        while (cargar == true)
        {
            if (fuerza < 300)
            {
                fuerza++;
                game.IncPotencia();
            }
            else cargar = false;
        }
    }
    
    public void OnMouseUp()
    {
        cargar = false;
        balaInstancia = Instantiate(bala, inicio, Quaternion.identity);

        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        cañon.material.color = Color.white;
        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio) * fuerza);
        game.IncBalas();
        game.DecPotencia();
    }

}