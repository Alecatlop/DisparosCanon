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
    //private Vector2 moveinput;
    GameObject cañon;
       

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       cañon = GameObject.Find("Padrecañon");
       
    }
    private void FixedUpdate()
    {
        cañon.transform.LookAt(transform.position);


        
        transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, transform.position.y + Input.GetAxisRaw("Vertical") * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp((transform.position.x), -8.6f, 5.6f), Mathf.Clamp((transform.position.y), 0.1f, 4f));

    }
    // Update is called once per frame
    void Update()
    {
        
        
    }

    //void OnApuntar(InputValue valor) 
    //{
    //    moveinput = valor.Get<Vector2>();
    //    rb.velocity = new Vector3(moveinput.x * speed, moveinput.y * speed, rb.velocity.z);

    //}

}
