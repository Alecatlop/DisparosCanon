using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.ShaderData;

public class Menu : MonoBehaviour
{
    GameObject dificultad;
    GameObject opciones;
    Dificultad nivel;
    AudioSource boton;

    // Start is called before the first frame update
    void Start()
    {
        
        dificultad = GameObject.Find("dificultad");
        opciones = GameObject.Find("opciones 1");
        dificultad.SetActive(false);
        nivel = GameObject.Find("Persistente").GetComponent<Dificultad>();
        boton = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Escape))
        {
            dificultad.SetActive(false);
            opciones.SetActive(true);
        }
    }

    public void Jugar()
    {
        boton.Play();
        dificultad.SetActive(true);
        opciones.SetActive(false);
    }

    public void Creditos()
    {
        boton.Play();
        SceneManager.LoadScene("Creditos");
    }

    public void Salir()
    {
        boton.Play();
        Application.Quit();
    }

    public void Fácil()
    {
        boton.Play();
        SceneManager.LoadScene("Juego");
        nivel.niveldificil = false;
        nivel.nivelfacil = true;
    }

    public void Difícil()
    {
        boton.Play();
        SceneManager.LoadScene("Juego");
        nivel.niveldificil = true;
        nivel.nivelfacil = false;
    }
}
