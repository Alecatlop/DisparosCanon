using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Botonblanco : MonoBehaviour
{
    public GameObject bala;
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
        
        // Disparar Bala
        Vector3 inicio = posicion.transform.position;
        Vector3 tamaño = bala.transform.localScale;
        int fuerzarandom = Random.Range(100, 400);
        int colorandom = Random.Range(1, 6);
        float escalarandom = Random.Range( 0.3f, 2f);
        
        bala.transform.localScale = tamaño * escalarandom;
        GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
        balaInstancia.name = "Bala " + contadorBalas;
        contadorBalas++;
        balaInstancia.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerzarandom, fuerzarandom));


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


        // resetear escala y color del prefab
        if (escalarandom != 1)
        {
            bala.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
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
