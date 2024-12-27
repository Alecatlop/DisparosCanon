using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    GameObject posicion;
    GameObject cruceta;
    int contadorBalas = 0;
    public GameManagerscript game;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 fin;
    bool cargar = false;
    public ParticleSystem chispa;
    float rotx = 90;
    float roty = 90;
    float rotz = 0;
    public AudioSource cannon;

    // Start is called before the first frame update
    void Start()
    {
        posicion = GameObject.Find("Posicion");
        cruceta = GameObject.Find("Mira");
    }

    private void Update()
    {
        //rotx = posicion.transform.rotation.x;
        //roty = posicion.transform.rotation.y;
        //rotz = posicion.transform.rotation.z;

        //bala.transform.LookAt(fin);
    }

    // Update is called once per frame
    public void Mantener()
    {
        inicio = posicion.transform.position;
        fin = cruceta.transform.position;

        if (cargar == true)
        {
            if (fuerza < 300)
            {
                fuerza++;
                game.IncPotencia();
            }
        }
    }

    public void Apretar()
    {
        cargar = true;
    }
    

    public void Soltar()
    {
        cargar = false;

        balaInstancia = Instantiate(bala, inicio, Quaternion.identity);

        balaInstancia.name = "Bala" + contadorBalas;
        contadorBalas++;

        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio) * fuerza);
        game.IncBalas();
        game.DecPotencia();

        chispa.Play();
        cannon.Play();
    }

}