using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public float velocidad;
    // Ejecuta al inicio , al momento de dar play.
    void Start()
    {
        velocidad = 8f;
        
    }

     // Se ejecuta  que vamos jugar frame x frame.
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime, 0,0);
        Debug.Log("La velocidad del perosnaje es :" + velocidad);//Desplacamiento del objeto
        
    }
}
