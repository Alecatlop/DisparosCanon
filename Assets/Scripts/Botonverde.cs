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

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //Disparar Bala

        
        Vector3 inicio = posicion.transform.position;
        GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;

        
        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce(new Vector3 (0, fuerza, fuerza));


        game.IncBalas();

    }

}
