using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonrojo : MonoBehaviour
{

    GameObject[] balas;
    public GameManagerscript game;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {

        balas = GameObject.FindGameObjectsWithTag("bala");

        foreach (GameObject bala in balas)
        {
            Destroy(bala);
        }

        game.EliminarBalas();
    }

    
    // static void y variables para acceder desde otros scripts al manager static int balas; en mouseGameManager.ResetearBalas();   llamar a función static public voi resetear balas(){
   
}

