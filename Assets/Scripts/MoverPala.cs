using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPala : MonoBehaviour {

    public float velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Vertical") == 1){//hacia arriba
            float ejeY = -1;
            ejeY = ejeY + Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime;
        }
        if(Input.GetAxisRaw("Vertical") == -1){//hacia abajo
            float ejey = Input.GetAxisRaw("Vertical") * velocidad * Time.deltaTime;
        }
	}
}
