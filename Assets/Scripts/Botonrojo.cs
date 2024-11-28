using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonrojo : MonoBehaviour
{
    GameObject[] balas;
    // Start is called before the first frame update
    void Start()
    {
        balas = GameObject.FindGameObjectsWithTag("bala");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        for (int a = 0; a < balas.Length; a++)
        {
            //Destroy(balas(a));
        }
        
    }
}
