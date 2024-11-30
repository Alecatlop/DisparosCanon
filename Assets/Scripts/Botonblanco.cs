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
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        Vector3 tama�o = bala.transform.localScale;
        int fuerzarandom = Random.Range(5, 51);
        float escalarandom = Random.Range( 0.3f, 1.5f);
        
        
            bala.transform.localScale = tama�o * escalarandom;
            GameObject balaInstancia = Instantiate(bala, inicio, Quaternion.identity);
            balaInstancia.name = "Bala " + contadorBalas;
            contadorBalas++;
            rb.AddForce(new Vector3(0, 0, fuerzarandom));
        

        // resetear escala prefab 
        if (escalarandom != 1)
        {
            bala.transform.localScale = new Vector3(1, 1, 1);
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
