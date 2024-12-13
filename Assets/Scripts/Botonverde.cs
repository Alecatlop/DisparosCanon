using System.Collections;
using System.Collections.Generic;
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

        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio)* fuerza);

        game.IncBalas();
    }

    public void OnMouseUp()
    {
        game.IncPotencia();
    }

}