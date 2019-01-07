using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EmpezarPartida : MonoBehaviour
{

    public Vidas vida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {//si se ha pulsado la tecla control derecha o izquierda se inicia el juego.
            vida = new Vidas();
            vida.reiniciarVidas();
            Console.WriteLine("Hola");
            SceneManager.LoadScene("Juego");
        }
    }
}
