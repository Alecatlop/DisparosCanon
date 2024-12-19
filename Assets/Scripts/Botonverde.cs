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
    //public Renderer cañon;
    GameObject balaInstancia;
    Vector3 inicio;
    Vector3 fin;
    bool cargar = false;
    public ParticleSystem chispa;
    float rotx = 90;
    float roty = 90;
    float rotz = 0;

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion2");
       cruceta = GameObject.Find("cruceta");
    }

    // Update is called once per frame
    void Update()
    {
        inicio = posicion.transform.position;
        fin = cruceta.transform.position;

        rotx = posicion.transform.rotation.x;
        roty = posicion.transform.rotation.y;
        rotz = posicion.transform.rotation.z;

        if (cargar == true)
        {
            if (fuerza < 300)
            {
                fuerza++;
                game.IncPotencia();
            }
        }
    }

    public void OnMouseDown()
    {
        cargar = true;
        //cañon.material.color = Color.red;
    }
    
    public void OnMouseUp()
    {
        cargar = false;
        balaInstancia = Instantiate(bala, inicio, Quaternion.Euler(rotx, roty, rotz));

        balaInstancia.name = "Bullet00" + contadorBalas;
        contadorBalas++;

        //cañon.material.color = Color.white;
        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio) * fuerza);
        game.IncBalas();
        game.DecPotencia();

        chispa.Play();
    }

}