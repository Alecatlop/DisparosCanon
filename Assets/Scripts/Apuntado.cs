using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Apuntado : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public GameObject cañon;
    public GameObject cañonbase;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       
    }
    private void FixedUpdate()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        cañon.transform.LookAt(transform.position);

        transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, transform.position.y + Input.GetAxisRaw("Vertical") * Time.deltaTime * speed);
        transform.position = new Vector3(Mathf.Clamp((transform.position.x), -8.6f, 5.6f), Mathf.Clamp((transform.position.y), 0.1f, 4f));

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (cañonbase.transform.rotation.y > -45)
            {
                cañonbase.transform.Rotate(new Vector3(0, -7f, 0) * Time.deltaTime * speed);
            }

        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (cañonbase.transform.rotation.y < 45)
            {
                cañonbase.transform.Rotate(new Vector3(0, 7f, 0) * Time.deltaTime * speed);
            }
        }

        //cañonbase.transform.Rotate(new Vector3(0, transform.rotation.y + Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0));
    }

}
