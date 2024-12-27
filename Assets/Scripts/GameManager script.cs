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
    GameObject pausa;
    Dificultad nivel;
    public AudioSource button;
    public AudioSource win;
    public AudioSource defeat;
    public AudioSource music2;

    // Start is called before the first frame update
    void Start()
    {
        referencia = FindObjectOfType<Boton>();
        victoria = GameObject.Find("Victoria");
        derrota = GameObject.Find("Derrota");
        estadísticas = GameObject.Find("Estadísticas");
        diana = GameObject.Find("Diana");
        puntero = GameObject.Find("Mira");
        pausa = GameObject.Find("Pausa");
        boton = GameObject.Find("Boton");
        estadísticas.SetActive(false);
        victoria.SetActive(false);
        derrota.SetActive(false);
        pausa.SetActive(false);
        nivel = GameObject.Find("Persistente").GetComponent<Dificultad>();

        

        if (nivel.nivelfacil == true)
        {
            numtiempo = 20;
            music2.volume = 1f;
            music2.pitch = 1f;
        }
        if (nivel.niveldificil == true)
        {
            numtiempo = 15;
            music2.volume = 1f;
            music2.pitch = 1.2f;
        }
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


            if (numdianas == numbalas && numbalas != 0)
            {
                redondeo = 100;
            }
            else if (numbalas == numdianas && numbalas == 0)
            {
                redondeo = 0;
            }

            contadorprecisión.text = "Precision: " + redondeo + "%";
            Final();
        }

        if (Input.GetKey(KeyCode.Escape) && numtiempo > 0)
        {
            music2.volume = 0.5f;
            music2.pitch = 0.9f;
            Time.timeScale = 0;
            pausa.SetActive(true);
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
        if (nivel.nivelfacil == true)
        {
            numtiempo += 3;
            music2.pitch = 1f;
        }
        if (nivel.niveldificil == true)
        {
            music2.pitch = 1.2f;
            numtiempo ++;
        }
        
        contadortiempo.text = "" + numtiempo;
    }

    public void Final()
    {
        if (precision > 50f && numdianas > 10)
        {
            win.Play();
            victoria.SetActive(true);
        }
        else 
        {
            defeat.Play();
            derrota.SetActive(true);
        }
    }

    public void Volver()
    {
        button.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Continuar()
    {
        if (nivel.nivelfacil == true)
        {
            music2.volume = 1f;
            music2.pitch = 1f;
        }
        if (nivel.niveldificil == true)
        {
            music2.volume = 1f;
            music2.pitch = 1.2f;
        }
        
        button.Play();
        Time.timeScale = 1;
        pausa.SetActive(false);
    }

}
