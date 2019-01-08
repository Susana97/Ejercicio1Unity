using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPala : MonoBehaviour
{

    public float velocidad = 10f;
    public Vector3 mov;
    public bool enJuego;
    public Vector3 posicionInicial;
    private float eje_y;
    public ElementoInteractivo botonUp;
    public ElementoInteractivo botonDown;

    // Use this for initialization
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || botonUp.pulsado || botonDown.pulsado)
        {
            if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                eje_y = Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime;
            }
            else if (botonUp.pulsado)
            {
                eje_y = 1 * velocidad * Time.deltaTime;
            }else if (botonDown.pulsado)
            {
                eje_y = -1 * velocidad * Time.deltaTime;
            }
            //se calcula el nuevo valor de y.
            if (eje_y != 0)
            {//si se pulsa las teclas de arriba o abajo.
                if ((transform.position.y < 2.01 && eje_y > 0) || (transform.position.y > -2.01 && eje_y < 0))
                {
                    mov = new Vector3(0, eje_y, 0);
                    transform.position += mov;
                }
            }
        }
    }

    public void Reset()
    {
        transform.position = posicionInicial;
    }
}
