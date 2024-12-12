using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerscript : MonoBehaviour
{
    public TextMeshProUGUI contador;
    int numbalas = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EliminarBalas()
    {
        numbalas = 0;
        contador.text = numbalas + " balas";
    }

    public void IncBalas()
    {
        numbalas++;
        contador.text = numbalas + " balas";
    }

   

}
