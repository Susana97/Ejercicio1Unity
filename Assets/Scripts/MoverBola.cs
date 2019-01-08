using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour {

    public float velocidadInicial = 400f;
    public Rigidbody rig;
    public Transform barra;
    public bool enJuego = false;
    Vector3 posicionInicial;
    public ElementoInteractivo pantallaCompleta;

	// Use this for initialization
	void Start () {
        posicionInicial = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (enJuego == false && (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl) || pantallaCompleta.pulsado)){
           
            enJuego = true; //se inicia el juego. 
            transform.SetParent(null); //la bola deja de ser hija de la barra.
            rig.isKinematic = false;
            rig.AddForce(new Vector3(-velocidadInicial, velocidadInicial, 0));
            
        }
	}

    public void Reset(){
        transform.position = posicionInicial;
        transform.SetParent(barra);//la bola vuelve a ser hija de la pala.
        enJuego = false;
        rig.isKinematic = true;
        rig.AddForce(Vector3.zero);
    }
}
