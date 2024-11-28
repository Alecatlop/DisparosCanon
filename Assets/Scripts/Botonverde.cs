using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Botonverde : MonoBehaviour
{
    GameObject bala;
    public int fuerza;
    GameObject cañon;
    public TextMeshProUGUI contador;
    int numbalas = 10;
    GameObject posicion;

    // Start is called before the first frame update
    void Start()
    {
       bala = GameObject.Find("Bala");
       cañon = GameObject.Find("Cañon");
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

        if(numbalas > 0)
        {
            Instantiate(bala, inicio, Quaternion.identity);
            rb.AddForce(new Vector3(fuerza, 0));
        }
        

        // Cambio de color del cañon
        float num1 = Random.Range(0f, 1f);
        float num2 = Random.Range(0f, 1f);
        float num3 = Random.Range(0f, 1f);
        cañon.GetComponent<Renderer>().material.color = new Color(num1, num2, num3);

        // Contador de Balas
        if (numbalas > 0)
        {
            numbalas--;

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
                contador.text = "Sin Munición";
            }
        }
    }
}
