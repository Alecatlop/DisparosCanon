using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
        float num1 = Random.Range(0f, 1f);
        float num2 = Random.Range(0f, 1f);
        float num3 = Random.Range(0f, 1f);
        rd.material.color = new Color(num1, num2, num3);
    }
}
