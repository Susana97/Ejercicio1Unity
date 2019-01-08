using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EmpezarPartida : MonoBehaviour
{

    public Vidas vida;
    public ElementoInteractivo botonUnJugador;
    public ElementoInteractivo botonDosJugadores;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (botonUnJugador.pulsado)
        {
            vida = new Vidas();
            vida.reiniciarVidas();
            SceneManager.LoadScene("Juego1");
        }

        if (botonDosJugadores.pulsado)
        {
            vida = new Vidas();
            vida.reiniciarVidas();
            SceneManager.LoadScene("Juego2");
        }

        if((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKey(KeyCode.L))
        {//si se ha pulsado CTRL - L se inicia dos jugadores.
            vida = new Vidas();
            vida.reiniciarVidas();
            SceneManager.LoadScene("Juego1");
        }

        if ((Input.GetKey(KeyCode.AltGr) || Input.GetKey(KeyCode.RightAlt) || Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey(KeyCode.L))
        {//si se ha pulsado Alt - L se inicia un jugador
            vida = new Vidas();
            vida.reiniciarVidas();
            SceneManager.LoadScene("Juego2");
        }
    }
}
