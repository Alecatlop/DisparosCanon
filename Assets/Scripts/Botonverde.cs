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
    GameObject[] balas;

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

        balas = GameObject.FindGameObjectsWithTag("bala");
        Vector3 inicio = posicion.transform.position;
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        
        GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;
        rb.AddForce(new Vector3(0, 0, fuerza));

        foreach (GameObject balacolor in balas)
        {
            Renderer mat = balacolor.GetComponent<Renderer>();
            mat.material.color = Color.black;
        }
        

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
