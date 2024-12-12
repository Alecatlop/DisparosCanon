using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Diana : MonoBehaviour
{
    public GameObject diana;
    GameObject[] ubi;
    GameObject bala;
    public GameManagerscript game;

    // Start is called before the first frame update
    void Start()
    {
        ubi = GameObject.FindGameObjectsWithTag("ubi");
        bala = GameObject.Find("Bala");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        int spawn = Random.Range(0, ubi.Length - 1);
        Vector3 posicion = ubi[spawn].transform.position;
        
        if (collision.gameObject.CompareTag("bala"))
        {
            //Destroy(bala);
            GameObject dianaInstancia = Instantiate(diana, posicion, Quaternion.Euler(90, 0, 0));
            Destroy(gameObject);
            game.IncDianas();
        }
        
    }
   
}
