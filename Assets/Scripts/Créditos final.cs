using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.ShaderData;

public class Créditosfinal : MonoBehaviour
{
    AudioSource music;
    public Animator consejo;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        StartCoroutine(Enumerator());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator Enumerator()
    {
        yield return new WaitForSeconds(0.3f);

        music.Play();

        yield return new WaitForSeconds(3.7f);

        consejo.SetBool("Consejo", true);

        yield return new WaitForSeconds(15f);

        SceneManager.LoadScene("Menu");
    }
}
