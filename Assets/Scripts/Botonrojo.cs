using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonrojo : MonoBehaviour
{

    GameObject[] balas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {

        balas = GameObject.FindGameObjectsWithTag("bala");

        foreach (GameObject bala in balas)
        {
            Destroy(bala);
        }
    }

    
    // static void y variables para acceder desde otros scripts al manager static int balas; en mouseGameManager.ResetearBalas();   llamar a función static public voi resetear balas(){
   
}

