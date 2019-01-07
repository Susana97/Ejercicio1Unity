using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    public Vidas vidas;
    public AudioSource vidaMenos;
    public AudioSource gameOverSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        vidas.restarVida();
        if (vidas.numVidas() == 0)
        {//si el numero de vidas es 0
            gameOverSound.Play();
        }
        else
        {
            vidaMenos.Play();
        }
        
    }
}
