using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class Apuntado : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    private Vector2 moveinput;
    GameObject cañon;
    //float minx = -8f, miny = -0.12f, maxx = 8f, maxy = 4f;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       cañon = GameObject.Find("Padrecañon");
    }

    // Update is called once per frame
    void Update()
    {
        cañon.transform.LookAt(transform.position);
    }

    void OnApuntar(InputValue valor) 
    {
        moveinput = valor.Get<Vector2>();
        //if (moveinput.x > minx && moveinput.x < maxx && moveinput.y > miny && moveinput.y < maxy)
        //{
        //    rb.velocity = new Vector3(moveinput.x * speed, moveinput.y * speed, rb.velocity.z);
        //}
        
        rb.velocity = new Vector3(moveinput.x * speed, moveinput.y * speed, rb.velocity.z);
    }

    private void OnTriggerExit(Collider other)
    {
        
    }


}
