using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerscript : MonoBehaviour
{
    public TextMeshProUGUI contadorbalas;
    public TextMeshProUGUI contadordianas;
    public TextMeshProUGUI contadorpotencia;
    public TextMeshProUGUI contadortiempo;
    int numbalas = 0;
    int numdianas = 0;
    float numtiempo = 20;
    public Boton referencia;
    GameObject estad�sticas;

    // Start is called before the first frame update
    void Start()
    {
        referencia = FindObjectOfType<Boton>();
        estad�sticas = GameObject.Find("Estad�sticas");
        estad�sticas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float segundos = Mathf.FloorToInt(numtiempo % 60);

        if (numtiempo > 0)
        {
            numtiempo -= Time.deltaTime;
            contadortiempo.text = "" + segundos;
        }
        else
        {
            numtiempo = 0; 
            contadortiempo.text = "" + segundos;
            estad�sticas.SetActive(true);
            contadorbalas.text = "Balas: " + numbalas;
            contadordianas.text = "Dianas: " + numdianas;
        }
        
    }

    public void IncBalas()
    {
        numbalas++;
    }

    public void IncDianas()
    {
        numdianas++;
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

    public void Tiempoextra()
    {
        numtiempo += 3;
        contadortiempo.text = "" + numtiempo;
    }

}
