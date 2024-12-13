using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerscript : MonoBehaviour
{
    public TextMeshProUGUI contadorbalas;
    public TextMeshProUGUI contadordianas;
    public TextMeshProUGUI contadorpotencia;
    int numbalas = 0;
    int numdianas = 0;
    public Botonverde referencia;

    // Start is called before the first frame update
    void Start()
    {
        referencia = FindObjectOfType<Botonverde>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void DecBalas()
    {
        if (numbalas >= 0)
        {
            numbalas--;
        }

        contadorbalas.text = "Balas: " + numbalas;
    }

    public void IncBalas()
    {
        numbalas++;
        contadorbalas.text = "Balas: " + numbalas;
    }

    public void IncDianas()
    {
        numdianas++;
        contadordianas.text = "Dianas: " + numdianas;
    }

    public void IncPotencia()
    {
        contadorpotencia.color = Color.red;
        contadorpotencia.text = "Potencia: " + referencia.fuerza;
    }

    public void DecPotencia()
    {
        contadorpotencia.color = Color.white;
        referencia.fuerza = 0;
        contadorpotencia.text = "Potencia: " + referencia.fuerza;
    }

}
