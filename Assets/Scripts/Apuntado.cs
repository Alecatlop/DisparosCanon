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
    public float speed;
    public GameObject cañon;
    public GameObject cañonbase;
    float rotbase = 0f;

    // Start is called before the first frame update
    void Start()
    {
       
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

        //if (cañonbase.transform.rotation.eulerAngles.y > -45f || cañonbase.transform.rotation.eulerAngles.y < 45f)
        //{
        //    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //    {
        //        cañonbase.transform.Rotate(new Vector3(0, -7f, 0) * Time.deltaTime * speed);
        //    }
        //    else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        //    {
        //        cañonbase.transform.Rotate(new Vector3(0, 7f, 0) * Time.deltaTime * speed);
        //    }
        //}
        

        rotbase += Input.GetAxisRaw("Horizontal") * Time.deltaTime * 67.5f;
        rotbase = Math.Clamp(rotbase, -45, 45);

        cañonbase.transform.eulerAngles = new Vector3(0, rotbase, 0);
        
    }

}
