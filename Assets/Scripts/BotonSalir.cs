using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonSalir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {//si ha pulsado la tecla de salir.
            if(Application.loadedLevelName.Equals("Escena de Portada"))
            {//si estamos en la escena de portada.
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("Escena de Portada");
            }
        }
    }
}
