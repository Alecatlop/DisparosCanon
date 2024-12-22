using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    GameObject dificultad;
    GameObject opciones;
    Dificultad nivel;

    // Start is called before the first frame update
    void Start()
    {
        
        dificultad = GameObject.Find("dificultad");
        opciones = GameObject.Find("opciones 1");
        dificultad.SetActive(false);
        nivel = GameObject.Find("Persistente").GetComponent<Dificultad>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jugar()
    {
        dificultad.SetActive(true);
        opciones.SetActive(false);
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Fácil()
    {
        SceneManager.LoadScene("Juego");
        nivel.niveldificil = false;
        nivel.nivelfacil = true;
    }

    public void Difícil()
    {
        SceneManager.LoadScene("Juego");
        nivel.niveldificil = true;
        nivel.nivelfacil = false;
    }
}
