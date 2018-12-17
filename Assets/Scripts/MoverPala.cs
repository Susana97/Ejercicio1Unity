using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPala : MonoBehaviour {

    public float velocidad = 10f;
    public bool enJuego;
    public Vector3 movimiento;
    public Vector3 moveVelocity;
    public Vector3 posicionInicial;

    // Use this for initialization
    void Start() {
        //posicionInicial = transform.position;
        enJuego = true;
    }

    // Update is called once per frame
    void Update() {
        float ejex = 8.73F;
        float ejeY = Input.GetAxisRaw("Vertical");
        if (ejeY == 1){//hacia arriba
            ejeY = ejeY + (Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime);
            transform.position = new Vector3(ejex, ejeY, 0);
        }
        if(ejeY == -1){//hacia abajo
            ejeY = ejeY - (Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime);
            transform.position = new Vector3(ejex, ejeY, 0);
        }
        
    }
}
