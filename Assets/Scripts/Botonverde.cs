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
        Vector3 localizacion = posicion.transform.position;
        //Vector3 rotacion = posicion.transform.rotation
        //Instantiate(contador, localizacion, );
        Rigidbody rb = bala.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, fuerza));

        float num1 = Random.Range(0f, 1f);
        float num2 = Random.Range(0f, 1f);
        float num3 = Random.Range(0f, 1f);
        cañon.GetComponent<Renderer>().material.color = new Color(num1, num2, num3);

        if (numbalas > 0)
        {
            numbalas--;

            if (numbalas > 1)
            {
                contador.text = numbalas + " balas";
            }
            else contador.text = numbalas + " bala";
        }

    }
}
