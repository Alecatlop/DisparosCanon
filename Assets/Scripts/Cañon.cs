using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Cañon : MonoBehaviour
{
    GameObject cruceta;
    //LookAtConstraint cruceta;

    // Start is called before the first frame update
    void Start()
    {
        cruceta = GameObject.Find("cruceta");
    }

    // Update is called once per frame
    void Update()
    {
        cruceta.transform.LookAt(transform.position);
    }

    void OnApuntar() 
    { 
        transform.Rotate;
        print("hola");
    }

   
}
