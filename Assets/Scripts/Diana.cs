using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Diana : MonoBehaviour
{
    GameObject bala;
    public GameManagerscript game;
    public AudioSource point;

    // Start is called before the first frame update
    void Start()
    {
        bala = GameObject.Find("Bala");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("bala"))
        {
            point.Play();
            float randx = Random.Range(-7f, 4f);
            float randy = Random.Range(0.5f, 4f);
            transform.position = new Vector3(randx, randy,0); 
            game.IncDianas();
            game.Tiempoextra();
        }
        
    }
   
}
