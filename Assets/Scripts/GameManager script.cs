using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerscript : MonoBehaviour
{
    public TextMeshProUGUI contadorbalas;
    public TextMeshProUGUI contadordianas;
    int numbalas = 0;
    int numdianas = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DecBalas()
    {
        numbalas--;
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
        //numbalas++;
        //contadorbalas.text = "Potencia: " + numbalas;
    }

    // doble click sobre variale nombre variable y boton derecho cmabiar nombre de todas
    // lookAt funcion para objeto vacio cañon, collider limitar cruceta caiga no salir, 
    // spawn, gamebojects vacios con la posicion de las crucetas mediante tag, en el random el maximo es la lista.length -1 porque se incluye, el transformposition de diana = al random
    // con prefab diana instanciar y destruir cada vez que toque con una bala en una posicion aleatoria 
    // los comandos usar inputsystem, 
}
