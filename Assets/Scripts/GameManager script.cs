using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerscript : MonoBehaviour
{
    public TextMeshProUGUI contadorbalas;
    public TextMeshProUGUI contadordianas;
    public TextMeshProUGUI contadorpotencia;
    public TextMeshProUGUI contadorprecisión;
    public TextMeshProUGUI contadortiempo;
    private GameObject victoria;
    private GameObject derrota;
    float numbalas = 0;
    float numdianas = 0;
    public float numtiempo = 0;
    float precision = 0;
    public Boton referencia;
    GameObject estadísticas;
    GameObject diana;
    GameObject puntero;
    GameObject boton;
    Dificultad nivel;

    // Start is called before the first frame update
    void Start()
    {
        referencia = FindObjectOfType<Boton>();
        victoria = GameObject.Find("Victoria");
        derrota = GameObject.Find("Derrota");
        estadísticas = GameObject.Find("Estadísticas");
        diana = GameObject.Find("Diana");
        puntero = GameObject.Find("cruceta");
        boton = GameObject.Find("Boton");
        estadísticas.SetActive(false);
        victoria.SetActive(false);
        derrota.SetActive(false);
        nivel = GameObject.Find("Persistente").GetComponent<Dificultad>();

        if (nivel.nivelfacil == true)
        {
            numtiempo = 20;
        }
        if (nivel.niveldificil == true)
        {
            numtiempo = 10;
        }
    }

    private void Awake()
    {
        
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
            estadísticas.SetActive(true);
            boton.SetActive(false);
            puntero.SetActive(false);
            diana.SetActive(false);
            contadorbalas.text = "Balas: " + numbalas;
            contadordianas.text = "Dianas: " + numdianas;
            
            precision = (numdianas / numbalas) * 100;
            float redondeo = Mathf.FloorToInt(precision % 100);
            contadorprecisión.text = "Precisión: " + redondeo + "%";
            Final();
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
        contadorpotencia.text = "" + referencia.fuerza;
    }

    public void DecPotencia()
    {
        contadorpotencia.color = Color.black;
        referencia.fuerza = 0;
        contadorpotencia.text = "" + referencia.fuerza;
    }

    public void Tiempoextra()
    {
        numtiempo += 3;
        contadortiempo.text = "" + numtiempo;
    }

    public void Final()
    {
        if (precision > 50f && numdianas > 10)
        {
            victoria.SetActive(true);
        }
        else derrota.SetActive(true);
    }

    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }

}
