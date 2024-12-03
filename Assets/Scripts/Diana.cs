using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Diana : MonoBehaviour
{
    int vidas = 2;
    Renderer colordiana;

    // Start is called before the first frame update
    void Start()
    {
        colordiana = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas < 1)
        {
            this.gameObject.transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (vidas == 0)
        {
            Destroy(gameObject);
        }
        else if (vidas == 1)
        {
            vidas--;
        }
        else if (vidas == 2)
        {
            colordiana.material.color = Color.white;
            vidas--;
        }
    }
   
}
