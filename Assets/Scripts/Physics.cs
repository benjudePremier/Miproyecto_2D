using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // // Ejecuta al inicio , al momento de dar play.
    public int Rigidbody;
    void Start()
    {
        Rigidbody = 100;
        
    }

    // Se ejecuta  que vamos jugar frame x frame.
    
    void Update()
    {

        if (Input.GetKey("w"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100));
            //Obtengo el Rigidbody del objeto y añade fuerzas(x,y)
            Debug.Log("El personaje que se meuve y salte :" + Rigidbody);


        }

    }
}
