using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public static int vidas;
    public Text textoVidas;
    public MoverPala miPala;
    public MoverBola miBola;
    public GameObject gameOver;
    


    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        string textoVidasSinNum = "VIDAS = ";
        textoVidas.text = textoVidasSinNum + vidas; //se inicializa el texto vidas a 3
    }

    // Update is called once per frame
    void Update()
    {
        if(vidas == 0)
        {
            gameOver.SetActive(true);
            Invoke("cargarPresentacion", 2);
        }
    }

    public void reiniciarVidas()
    {
        vidas = 3;
    }

    public void restarVida()
    {
        vidas = vidas -1;
        string textoVidasSinNum = "VIDAS = ";
        textoVidas.text = textoVidasSinNum + vidas; //se actualiza el marcador.
        miPala.Reset();
        miBola.Reset();
    }

    public int numVidas()
    {
        return vidas;
    }

    public void cargarPresentacion()
    {
        SceneManager.LoadScene("Escena de Portada");
    }

}
