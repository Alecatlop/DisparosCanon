using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Botonblanco : MonoBehaviour
{
    public GameObject bala;
    GameObject posicioninicio;
    GameObject posicionfin;
    Vector3 inicio;
    GameObject final;
    int contadorBalas = 0;
    public GameManagerscript game;

    // Start is called before the first frame update
    void Start()
    {
        posicioninicio = GameObject.Find("Posicion inicio");
        posicionfin = GameObject.Find("Posicion fin");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        
        // Disparar Bala
        Vector3 inicio = posicioninicio.transform.position;
        Vector3 fin = posicionfin.transform.position;
        Vector3 tamaño = bala.transform.localScale;
        int fuerzarandom = Random.Range(100, 400);
        int colorandom = Random.Range(1, 6);
        float escalarandom = Random.Range( 0.1f, 2f);
        bala.transform.localScale = tamaño * escalarandom;
        GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;
        balaInstancia.GetComponent<Rigidbody>().AddForce((fin - inicio)*fuerzarandom);


        if (colorandom == 1)
        {
            balaInstancia.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (colorandom == 2)
        {
            balaInstancia.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (colorandom == 3)
        {
            balaInstancia.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (colorandom == 4)
        {
            balaInstancia.GetComponent<Renderer>().material.color = Color.blue;
        }
        else balaInstancia.GetComponent<Renderer>().material.color = Color.white;


        // resetear escala del prefab
        if (escalarandom != 1)
        {
            bala.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        //Contador de Balas
        game.IncBalas();

    }
}
