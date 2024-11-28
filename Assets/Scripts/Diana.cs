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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("bala"))
        {

            if (vidas == 0)
            {
                print("Vidas " + vidas);
                Destroy(gameObject);
            }
            else if (vidas == 1)
            {
                print("Vidas " + vidas);
                transform.Rotate(0, 0, 90 * Time.deltaTime);
                vidas--;
            }
            else if (vidas == 2)
            {
                colordiana.material.color = Color.white;
                print("Vidas " + vidas);
                vidas--;
            }
        }

    }
}
