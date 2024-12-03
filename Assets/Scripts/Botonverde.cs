using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    public GameObject bala;
    public int fuerza;
    public TextMeshProUGUI contador;
    int numbalas = 0;
    GameObject posicion;
    int contadorBalas = 0;
    

    // Start is called before the first frame update
    void Start()
    {
       posicion = GameObject.Find("Posicion");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //Disparar Bala

        
        Vector3 inicio = posicion.transform.position;
        //Rigidbody rb = bala.GetComponent<Rigidbody>();
        
        GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;
        //rb.AddForce(new Vector3(0, 0, fuerza));

        
        balaInstancia.GetComponent<Renderer>().material.color = Color.black;
        balaInstancia.GetComponent<Rigidbody>().AddForce(new Vector3 (0, fuerza, fuerza));
        
        

        //Contador de Balas
       
            numbalas++;

            if (numbalas > 1)
            {
                contador.text = numbalas + " balas";
            }
            else if (numbalas == 1)
            {
                contador.text = numbalas + " bala";
            }
            else if (numbalas < 1)
            {
                contador.text = "Sin balas";

            }
        
    }

}
