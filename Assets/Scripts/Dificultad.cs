using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificultad : MonoBehaviour
{
    public bool nivelfacil;
    public bool niveldificil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        DontDestroyOnLoad(GameObject.Find("Persistente"));
        nivelfacil = false;
        niveldificil = false;
    }
}
